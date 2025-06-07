namespace LinkedHeap.Tests
{
  /// <summary>
  /// Unit tests for <see cref="HeapStack{T}"/> to verify push, pop, peek, order,
  /// event firing, and reuse of heap nodes.
  /// </summary>
  [TestFixture]
  public unsafe class HeapStackTests
  {
    /// <summary>
    /// The <see cref="CustomHeap{T}"/>.
    /// </summary>
    private CustomHeap<int>? _heap;

    /// <summary>
    /// The <see cref="HeapStack{T}"/> we are testing.
    /// </summary>
    private HeapStack<int>? _stack;

    /// <summary>
    /// Sets up a new heap and stack before each test.
    /// </summary>
    [SetUp]
    public void Setup()
    {
      _heap = new CustomHeap<int>(initialCapacity: 4);
      _stack = new HeapStack<int>(_heap);
    }

    /// <summary>
    /// Disposes the heap and clears references after each test.
    /// </summary>
    [TearDown]
    public void Teardown()
    {
      _stack = null;
      _heap?.Dispose();
      _heap = null;
    }

    /// <summary>
    /// Verifies that Push and Pop respect LIFO order, Peek returns the correct element,
    /// and IsEmpty toggles appropriately.
    /// </summary>
    [Test]
    public void Push_Pop_ShouldRespectLIFOOrder()
    {
      _stack!.Push(10);
      _stack.Push(20);
      _stack.Push(30);

      Assert.That(_stack.IsEmpty, Is.False, "Stack should not be empty after pushes.");
      Assert.That(_stack.Peek(), Is.EqualTo(30), "Peek should return last pushed value.");

      int popped1 = _stack.Pop();
      Assert.That(popped1, Is.EqualTo(30), "First Pop should return 30.");
      Assert.That(_stack.Peek(), Is.EqualTo(20), "After popping, Peek should return next element (20).");

      int popped2 = _stack.Pop();
      Assert.That(popped2, Is.EqualTo(20), "Second Pop should return 20.");

      int popped3 = _stack.Pop();
      Assert.That(popped3, Is.EqualTo(10), "Third Pop should return 10.");

      Assert.That(_stack.IsEmpty, Is.True, "Stack should be empty after popping all elements.");
    }

    /// <summary>
    /// Verifies that popping an empty stack throws <see cref="InvalidOperationException"/>.
    /// </summary>
    [Test]
    public void Pop_EmptyStack_ShouldThrowInvalidOperationException()
    {
      Assert.That(_stack!.IsEmpty, Is.True, "Stack should start empty.");
      Assert.That(() => _stack.Pop(),
                  Throws.InvalidOperationException,
                  "Popping an empty stack should throw InvalidOperationException.");
    }

    /// <summary>
    /// Verifies that peeking an empty stack throws <see cref="InvalidOperationException"/>.
    /// </summary>
    [Test]
    public void Peek_EmptyStack_ShouldThrowInvalidOperationException()
    {
      Assert.That(() => _stack!.Peek(),
                  Throws.InvalidOperationException,
                  "Peeking an empty stack should throw InvalidOperationException.");
    }

    /// <summary>
    /// Verifies that <see cref="HeapStack{T}.GetNodePointers"/> returns pointers
    /// in correct LIFO sequence corresponding to values.
    /// </summary>
    [Test]
    public void GetNodePointers_ShouldReturnCorrectPointerSequence()
    {
      _stack!.Push(1);
      _stack.Push(2);
      _stack.Push(3);

      var pointers = _stack.GetNodePointers().ToList();
      Assert.That(pointers, Has.Count.EqualTo(3), "Should have 3 node pointers.");

      var values = pointers.Select(ptr => ((HeapNode<int>*)ptr)->Value).ToList();
      Assert.That(values, Is.EqualTo(new[] { 3, 2, 1 }), "Pointer sequence should correspond to values [3,2,1].");
    }

    /// <summary>
    /// Verifies that <see cref="HeapStack{T}.OnChanged"/> fires once per Push or Pop.
    /// </summary>
    [Test]
    public void OnChanged_EventFires_OnPushAndPop()
    {
      int changedCount = 0;
      _stack!.OnChanged += () => changedCount++;

      _stack.Push(5);
      _stack.Push(6);
      Assert.That(changedCount, Is.EqualTo(2), "OnChanged should fire for each Push.");

      _stack.Pop();
      Assert.That(changedCount, Is.EqualTo(3), "OnChanged should fire for Pop as well.");
    }

    /// <summary>
    /// Verifies that pushing and popping repeatedly reuses the same heap nodes.
    /// </summary>
    [Test]
    public void PushingAndPoppingReusesHeapNodes()
    {
      for (int i = 0; i < 5; i++)
      {
        _stack!.Push(i);
      }

      var pointersBefore = _stack!.GetNodePointers().ToList();
      for (int i = 0; i < 5; i++)
      {
        _stack.Pop();
      }

      // Now free list should contain those 5 nodes; pushing again should reuse pointers
      _stack.Push(100);
      nint newPtr = _stack.GetNodePointers().First();

      Assert.That(pointersBefore, Does.Contain(newPtr),
                  "After popping, pushing should reuse one of the previously used nodes.");
    }
  }
}
