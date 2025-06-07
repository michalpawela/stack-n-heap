namespace LinkedHeap
{
  /// <summary>
  /// Manages a pool of unmanaged <see cref="HeapNode{T}"/> structs in native memory,
  /// allowing allocation and deallocation via raw pointers (exposed as <see cref="IntPtr"/>).
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  public unsafe interface IHeap<T> where T : unmanaged
  {
    /// <summary>
    /// Fires when a new <see cref="HeapNode{T}"/> is allocated.
    /// The argument is the pointer (as <see cref="IntPtr"/>) to the newly‐allocated node.
    /// </summary>
    event Action<IntPtr> OnAllocate;

    /// <summary>
    /// Fires when a <see cref="HeapNode{T}"/> is freed.
    /// The argument is the pointer (as <see cref="IntPtr"/>) to the freed node.
    /// </summary>
    event Action<IntPtr> OnFree;

    /// <summary>
    /// Allocates a node containing <paramref name="value"/> and returns its pointer as <see cref="IntPtr"/>.
    /// </summary>
    /// <param name="value">The payload to store in the node.</param>
    /// <returns>An <see cref="IntPtr"/> pointing to the newly‐allocated <see cref="HeapNode{T}"/>.</returns>
    IntPtr Allocate(T value);

    /// <summary>
    /// Frees the node at the given <paramref name="nodePtr"/> (which must have been previously allocated),
    /// returning it to the free list.
    /// </summary>
    /// <param name="nodePtr">Pointer (as <see cref="IntPtr"/>) to the node being freed.</param>
    void Free(IntPtr nodePtr);

    /// <summary>
    /// Enumerates every node in every allocated block (both free and in‐use),
    /// returning each pointer as <see cref="IntPtr"/> so that callers can inspect each <see cref="HeapNode{T}"/>.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{IntPtr}"/> of raw node pointers.</returns>
    IEnumerable<IntPtr> GetAllNodes();
  }
}
