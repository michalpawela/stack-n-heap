namespace LinkedHeap
{
  /// <summary>
  /// Wraps one <see cref="CustomHeap{T}"/>, one <see cref="HeapStack{T}"/>,
  /// and one <see cref="HeapQueue{T}"/> into a single injectable service.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  public sealed class LinkedHeapService<T> : IDisposable
      where T : unmanaged
  {
    /// <summary>
    /// The unmanaged heap instance.
    /// </summary>
    public IHeap<T> Heap { get; }

    /// <summary>
    /// The stack backed by the same unmanaged heap.
    /// </summary>
    public IStack<T> Stack { get; }

    /// <summary>
    /// The queue backed by the same unmanaged heap.
    /// </summary>
    public IQueue<T> Queue { get; }

    /// <summary>
    /// Creates a new <see cref="LinkedHeapService{T}"/> with:
    ///   - <see cref="CustomHeap{T}"/> as the heap,
    ///   - <see cref="HeapStack{T}"/> for the stack,
    ///   - <see cref="HeapQueue{T}"/> for the queue.
    /// </summary>
    public LinkedHeapService()
    {
      var customHeap = new CustomHeap<T>();
      Heap = customHeap;
      Stack = new HeapStack<T>(customHeap);
      Queue = new HeapQueue<T>(customHeap);
    }

    /// <summary>
    /// Disposes the underlying <see cref="CustomHeap{T}"/>.
    /// </summary>
    public void Dispose()
    {
      if (Heap is IDisposable d)
      {
        d.Dispose();
      }
    }
  }
}
