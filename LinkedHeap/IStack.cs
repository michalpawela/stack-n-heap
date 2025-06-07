namespace LinkedHeap
{
  /// <summary>
  /// A stack of <see cref="HeapNode{T}"/> pointers built on an <see cref="IHeap{T}"/>.
  /// All pointer manipulations are performed in unsafe code (LIFO).
  /// Exposes node pointers as <see cref="IntPtr"/> for public APIs.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  public unsafe interface IStack<T> where T : unmanaged
  {
    /// <summary>
    /// Fires whenever the stack’s top changes (via <see cref="Push"/> or <see cref="Pop"/>).
    /// </summary>
    event Action OnChanged;

    /// <summary>
    /// Returns <c>true</c> if the stack contains no elements.
    /// </summary>
    bool IsEmpty { get; }

    /// <summary>
    /// Pushes a new <paramref name="value"/> onto the top of the stack.
    /// </summary>
    /// <param name="value">Value to store in a freshly allocated node.</param>
    void Push(T value);

    /// <summary>
    /// Pops the top element off the stack and returns its value.
    /// Frees that node back into the <see cref="IHeap{T}"/>.
    /// </summary>
    /// <returns>The <typeparamref name="T"/> stored at the former top node.</returns>
    T Pop();

    /// <summary>
    /// Returns the value stored at the current top without removing it.
    /// </summary>
    /// <returns>The <typeparamref name="T"/> at the top.</returns>
    T Peek();

    /// <summary>
    /// Enumerates all allocated node pointers (as <see cref="IntPtr"/>) in LIFO order,
    /// starting from the current top down to the bottom.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{IntPtr}"/> of pointers from top to bottom.</returns>
    IEnumerable<IntPtr> GetNodePointers();
  }
}
