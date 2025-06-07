namespace LinkedHeap.Tests
{
  /// <summary>
  /// Unit tests for <see cref="HeapQueue{T}"/> to verify enqueue, dequeue, peek, order,
  /// event firing, and reuse of heap nodes.
  /// </summary>
  [TestFixture]
  public unsafe class HeapQueueTests
  {
    /// <summary>
    /// The <see cref="CustomHeap{T}"/>.
    /// </summary>
    private CustomHeap<int>? _heap;

    /// <summary>
    /// The <see cref="HeapQueue{T}"/> we are testing.
    /// </summary>
    private HeapQueue<int>? _queue;

    /// <summary>
    /// Sets up a new heap and queue before each test.
    /// </summary>
    [SetUp]
    public void Setup()
    {
      _heap = new CustomHeap<int>(initialCapacity: 4);
      _queue = new HeapQueue<int>(_heap);
    }

    /// <summary>
    /// Disposes the heap and clears references after each test.
    /// </summary>
    [TearDown]
    public void Teardown()
    {
      _queue = null;
      _heap?.Dispose();
      _heap = null;
    }

    /// <summary>
    /// Verifies that Enqueue and Dequeue respect FIFO order, Peek returns the correct element,
    /// and IsEmpty toggles appropriately.
    /// </summary>
    [Test]
    public void Enqueue_Dequeue_ShouldRespectFIFOOrder()
    {
      _queue!.Enqueue(7);
      _queue.Enqueue(14);
      _queue.Enqueue(21);

      Assert.That(_queue.IsEmpty, Is.False, "Queue should not be empty after enqueues.");
      Assert.That(_queue.Peek(), Is.EqualTo(7), "Peek should return first enqueued value (7).");

      int dequeued1 = _queue.Dequeue();
      Assert.That(dequeued1, Is.EqualTo(7), "First Dequeue should return 7.");
      Assert.That(_queue.Peek(), Is.EqualTo(14), "After one dequeue, Peek should return 14.");

      int dequeued2 = _queue.Dequeue();
      Assert.That(dequeued2, Is.EqualTo(14), "Second Dequeue should return 14.");

      int dequeued3 = _queue.Dequeue();
      Assert.That(dequeued3, Is.EqualTo(21), "Third Dequeue should return 21.");

      Assert.That(_queue.IsEmpty, Is.True, "Queue should be empty after dequeuing all elements.");
    }

    /// <summary>
    /// Verifies that dequeuing an empty queue throws <see cref="InvalidOperationException"/>.
    /// </summary>
    [Test]
    public void Dequeue_EmptyQueue_ShouldThrowInvalidOperationException()
    {
      Assert.That(_queue!.IsEmpty, Is.True, "Queue should start empty.");
      Assert.That(() => _queue.Dequeue(),
                  Throws.InvalidOperationException,
                  "Dequeuing an empty queue should throw InvalidOperationException.");
    }

    /// <summary>
    /// Verifies that peeking an empty queue throws <see cref="InvalidOperationException"/>.
    /// </summary>
    [Test]
    public void Peek_EmptyQueue_ShouldThrowInvalidOperationException()
    {
      Assert.That(() => _queue!.Peek(),
                  Throws.InvalidOperationException,
                  "Peeking an empty queue should throw InvalidOperationException.");
    }

    /// <summary>
    /// Verifies that <see cref="HeapQueue{T}.GetNodePointers"/> returns pointers
    /// in correct FIFO sequence corresponding to values.
    /// </summary>
    [Test]
    public void GetNodePointers_ShouldReturnCorrectPointerSequence()
    {
      _queue!.Enqueue(100);
      _queue.Enqueue(200);
      _queue.Enqueue(300);

      var pointers = _queue.GetNodePointers().ToList();
      Assert.That(pointers.Count, Is.EqualTo(3), "Should have 3 node pointers.");

      var values = pointers.Select(ptr => ((HeapNode<int>*)ptr)->Value).ToList();
      Assert.That(values, Is.EqualTo(new[] { 100, 200, 300 }),
                  "Pointer sequence should correspond to values [100,200,300].");
    }

    /// <summary>
    /// Verifies that <see cref="HeapQueue{T}.OnChanged"/> fires once per Enqueue or Dequeue.
    /// </summary>
    [Test]
    public void OnChanged_EventFires_OnEnqueueAndDequeue()
    {
      int changedCount = 0;
      _queue!.OnChanged += () => changedCount++;

      _queue.Enqueue(1);
      _queue.Enqueue(2);
      Assert.That(changedCount, Is.EqualTo(2), "OnChanged should fire for each Enqueue.");

      _queue.Dequeue();
      Assert.That(changedCount, Is.EqualTo(3), "OnChanged should fire for Dequeue as well.");
    }

    /// <summary>
    /// Verifies that enqueuing and dequeuing repeatedly reuses the same heap nodes.
    /// </summary>
    [Test]
    public void EnqueuingAndDequeuingReusesHeapNodes()
    {
      for (int i = 0; i < 5; i++)
      {
        _queue!.Enqueue(i);
      }

      var pointersBefore = _queue!.GetNodePointers().ToList();
      for (int i = 0; i < 5; i++)
      {
        _queue.Dequeue();
      }

      // Now free list contains those nodes; enqueue again should reuse pointers
      _queue.Enqueue(999);
      nint newPtr = _queue.GetNodePointers().First();

      Assert.That(pointersBefore, Does.Contain(newPtr),
                  "After dequeuing, enqueuing should reuse one of the previously used nodes.");
    }
  }
}
