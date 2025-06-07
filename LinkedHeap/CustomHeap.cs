using System.Runtime.InteropServices;

namespace LinkedHeap
{
  /// <summary>
  /// A custom heap manager that allocates unmanaged <see cref="HeapNode{T}"/> blocks,
  /// hands out node pointers as <see cref="IntPtr"/>, and tracks free nodes via a pointer chain.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  public unsafe class CustomHeap<T> : IHeap<T>, IDisposable
      where T : unmanaged
  {
    /// <summary>
    /// All allocated block base addresses.
    /// </summary>
    private readonly List<IntPtr> _blocks = [];

    /// <summary>
    /// Capacity (# nodes) for each block.
    /// </summary>
    private readonly List<int> _blockCapacities = [];

    /// <summary>
    /// Head of the free‐list chain (raw pointer).
    /// </summary>
    private HeapNode<T>* _freeListHead;

    /// <summary>
    /// Initial block size in nodes.
    /// </summary>
    private readonly int _initialCapacity;

    /// <summary>
    /// Next block’s capacity (we double each time).
    /// </summary>
    private int _nextBlockCapacity;

    /// <inheritdoc/>
    public event Action<IntPtr> OnAllocate = delegate { };

    /// <inheritdoc/>
    public event Action<IntPtr> OnFree = delegate { };

    /// <summary>
    /// Creates a new <see cref="CustomHeap{T}"/> with an initial capacity.
    /// </summary>
    /// <param name="initialCapacity">
    /// Number of nodes to allocate in the first block. Must be &gt; 0.
    /// </param>
    public CustomHeap(int initialCapacity = 1)
    {
      if (initialCapacity <= 0)
        throw new ArgumentOutOfRangeException(nameof(initialCapacity), "Capacity must be positive.");

      _initialCapacity = initialCapacity;
      _nextBlockCapacity = initialCapacity;
      AllocateBlock(_initialCapacity);
    }

    /// <inheritdoc/>
    public IntPtr Allocate(T value)
    {
      if (_freeListHead == null)
      {
        // No free nodes remain: allocate a new block (double size)
        AllocateBlock(_nextBlockCapacity);
        _nextBlockCapacity *= 2;
      }

      // Pop one node from the free‐list
      HeapNode<T>* node = _freeListHead;
      _freeListHead = node->Next;

      // Initialize the node
      node->Value = value;
      node->Next = null;
      node->InUse = 1;

      nint ptr = new(node);
      OnAllocate(ptr);
      return ptr;
    }

    /// <inheritdoc/>
    public void Free(IntPtr nodePtr)
    {
      if (nodePtr == IntPtr.Zero)
      {
        throw new InvalidOperationException("Cannot free a null pointer.");
      }

      var node = (HeapNode<T>*)nodePtr;
      if (node->InUse == 0)
      {
        throw new InvalidOperationException("Node is already freed.");
      }

      node->InUse = 0;
      node->Next = _freeListHead;
      _freeListHead = node;

      OnFree(nodePtr);
    }

    /// <inheritdoc/>
    public IEnumerable<IntPtr> GetAllNodes()
    {
      // Build a list of every node pointer in every block, then return it.
      var result = new List<IntPtr>();
      for (int blockIndex = 0; blockIndex < _blocks.Count; blockIndex++)
      {
        var basePtr = (HeapNode<T>*)_blocks[blockIndex];
        int capacity = _blockCapacities[blockIndex];

        for (int i = 0; i < capacity; i++)
        {
          result.Add(new IntPtr(&basePtr[i]));
        }
      }

      return result;
    }

    /// <summary>
    /// Allocates a new unmanaged block of <paramref name="capacity"/> <see cref="HeapNode{T}"/> structs,
    /// initializes its free‐list chain, and prepends it to the existing free list.
    /// </summary>
    /// <param name="capacity">Number of nodes to allocate in this block.</param>
    private void AllocateBlock(int capacity)
    {
      int nodeSize = sizeof(HeapNode<T>);
      nint rawBlock = Marshal.AllocHGlobal(nodeSize * capacity);
      _blocks.Add(rawBlock);
      _blockCapacities.Add(capacity);

      var firstNode = (HeapNode<T>*)rawBlock;
      // Link all nodes in this block into a local free‐list
      for (int i = 0; i < capacity; i++)
      {
        HeapNode<T>* current = &firstNode[i];
        current->InUse = 0;
        current->Next = (i < capacity - 1) ? &firstNode[i + 1] : null;
      }

      // If there was already a free list, link the new block’s last node to it
      if (_freeListHead != null)
      {
        HeapNode<T>* lastInNewBlock = &firstNode[capacity - 1];
        lastInNewBlock->Next = _freeListHead;
      }

      // Now point the free‐list head to this block’s first node
      _freeListHead = firstNode;
    }

    /// <summary>
    /// Frees all unmanaged memory blocks.
    /// </summary>
    public void Dispose()
    {
      foreach (nint block in _blocks)
      {
        Marshal.FreeHGlobal(block);
      }

      _blocks.Clear();
      _blockCapacities.Clear();
      _freeListHead = null;
      GC.SuppressFinalize(this);
    }
  }
}
