using System.Runtime.InteropServices;

namespace LinkedHeap
{
  /// <summary>
  /// Represents a single node in the custom unmanaged heap.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  [StructLayout(LayoutKind.Sequential)]
  public unsafe struct HeapNode<T> where T : unmanaged
  {
    /// <summary>
    /// The user’s payload. Stored in unmanaged memory.
    /// </summary>
    public T Value;

    /// <summary>
    /// Pointer to the next node in either:
    ///  • the free list (if <see cref="InUse"/> is 0), or
    ///  • a stack/queue link (if <see cref="InUse"/> is 1).
    /// </summary>
    public HeapNode<T>* Next;

    /// <summary>
    /// 1 if this node is currently allocated/in use; 0 if it is free.
    /// </summary>
    public byte InUse;
  }
}

