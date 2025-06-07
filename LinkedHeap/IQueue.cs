namespace LinkedHeap
{
  /// <summary>
  /// A queue of <see cref="HeapNode{T}"/> pointers built on an <see cref="IHeap{T}"/>.
  /// All pointer manipulations are done in unsafe code (FIFO).
  /// Exposes node pointers as <see cref="IntPtr"/> for public APIs.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  public unsafe interface IQueue<T> where T : unmanaged
  {
    /// <summary>
    /// Fires whenever an <see cref="Enqueue"/> or <see cref="Dequeue"/> changes the queue.
    /// </summary>
    event Action OnChanged;

    /// <summary>
    /// Returns <c>true</c> if the queue is empty.
    /// </summary>
    bool IsEmpty { get; }

    /// <summary>
    /// Enqueues a new <paramref name="value"/> into the queue.
    /// Allocates a fresh <see cref="HeapNode{T}"/> from the underlying heap.
    /// </summary>
    /// <param name="value">Value to enqueue.</param>
    void Enqueue(T value);

    /// <summary>
    /// Dequeues the front node, returns its value, and frees that node back to the heap.
    /// </summary>
    /// <returns>The <typeparamref name="T"/> that was stored in the front node.</returns>
    T Dequeue();

    /// <summary>
    /// Returns the <typeparamref name="T"/> stored at the queue’s head without removing it.
    /// </summary>
    /// <returns>The front value.</returns>
    T Peek();

    /// <summary>
    /// Enumerates all allocated node pointers (as <see cref="IntPtr"/>) in FIFO order,
    /// from head to tail.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{IntPtr}"/> of node pointers from head to tail.</returns>
    IEnumerable<IntPtr> GetNodePointers();
  }
}
