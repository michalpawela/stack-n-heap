namespace LinkedHeap
{
  /// <summary>
  /// A Last-In‐First-Out stack backed by <see cref="IHeap{T}"/>,
  /// using real <see cref="HeapNode{T}"/> pointers for linkage internally.
  /// Exposes node pointers as <see cref="IntPtr"/> for public enumeration.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  /// <remarks>
  /// Initializes a new instance of <see cref="HeapStack{T}"/> using the given unmanaged heap.
  /// </remarks>
  /// <param name="heap">An <see cref="IHeap{T}"/> to allocate/free nodes.</param>
  public unsafe class HeapStack<T>(IHeap<T> heap) : IStack<T> where T : unmanaged
  {
    /// <summary>
    /// The underlying unmanaged heap used to allocate and free nodes.
    /// </summary>
    private readonly IHeap<T> _heap = heap ?? throw new ArgumentNullException(nameof(heap));

    /// <summary>
    /// Pointer to the current top node of the stack; null if the stack is empty.
    /// </summary>
    private HeapNode<T>* _top = null;

    /// <inheritdoc/>
    public event Action OnChanged = delegate { };

    /// <inheritdoc/>
    public bool IsEmpty => _top == null;

    /// <inheritdoc/>
    public void Push(T value)
    {
      nint ptr = _heap.Allocate(value);
      var node = (HeapNode<T>*)ptr;

      node->Next = _top;
      _top = node;

      OnChanged();
    }

    /// <inheritdoc/>
    public T Pop()
    {
      if (_top == null)
        throw new InvalidOperationException("Stack is empty.");

      HeapNode<T>* node = _top;
      T result = node->Value;
      _top = node->Next;

      _heap.Free(new IntPtr(node));
      OnChanged();
      return result;
    }

    /// <inheritdoc/>
    public T Peek()
    {
      if (_top == null)
        throw new InvalidOperationException("Stack is empty.");

      return _top->Value;
    }

    /// <inheritdoc/>
    public IEnumerable<IntPtr> GetNodePointers()
    {
      // Build a list of pointers in LIFO order, then return it
      var result = new List<IntPtr>();
      HeapNode<T>* cursor = _top;
      while (cursor != null)
      {
        result.Add(new IntPtr(cursor));
        cursor = cursor->Next;
      }
      return result;
    }
  }
}
