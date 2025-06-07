namespace LinkedHeap
{
  /// <summary>
  /// A First-In‐First-Out queue backed by <see cref="IHeap{T}"/>,
  /// using real <see cref="HeapNode{T}"/> pointers internally.
  /// Exposes node pointers as <see cref="IntPtr"/> for public enumeration.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  /// <remarks>
  /// Initializes a new instance of <see cref="HeapQueue{T}"/> using the given unmanaged heap.
  /// </remarks>
  /// <param name="heap">An <see cref="IHeap{T}"/> to allocate/free nodes.</param>
  public unsafe class HeapQueue<T>(IHeap<T> heap) : IQueue<T> where T : unmanaged
  {
    /// <summary>
    /// The underlying unmanaged heap used to allocate and free nodes.
    /// </summary>
    private readonly IHeap<T> _heap = heap ?? throw new ArgumentNullException(nameof(heap));

    /// <summary>
    /// Pointer to the front node of the queue; null if the queue is empty.
    /// </summary>
    private HeapNode<T>* _head = null;

    /// <summary>
    /// Pointer to the back node of the queue; null if the queue is empty.
    /// </summary>
    private HeapNode<T>* _tail = null;

    /// <inheritdoc/>
    public event Action OnChanged = delegate { };

    /// <inheritdoc/>
    public bool IsEmpty => _head == null;

    /// <inheritdoc/>
    public void Enqueue(T value)
    {
      nint ptr = _heap.Allocate(value);
      var node = (HeapNode<T>*)ptr;

      if (_head == null)
      {
        // Empty queue
        _head = node;
        _tail = node;
      }
      else
      {
        _tail->Next = node;
        _tail = node;
      }

      OnChanged();
    }

    /// <inheritdoc/>
    public T Dequeue()
    {
      if (_head == null)
        throw new InvalidOperationException("Queue is empty.");

      HeapNode<T>* node = _head;
      T result = node->Value;
      _head = node->Next;

      if (_head == null)
        _tail = null;

      _heap.Free(new IntPtr(node));
      OnChanged();
      return result;
    }

    /// <inheritdoc/>
    public T Peek()
    {
      if (_head == null)
        throw new InvalidOperationException("Queue is empty.");

      return _head->Value;
    }

    /// <inheritdoc/>
    public IEnumerable<IntPtr> GetNodePointers()
    {
      // Build a list of pointers in FIFO order, then return it
      var result = new List<IntPtr>();
      HeapNode<T>* cursor = _head;
      while (cursor != null)
      {
        result.Add(new IntPtr(cursor));
        cursor = cursor->Next;
      }
      return result;
    }
  }
}
