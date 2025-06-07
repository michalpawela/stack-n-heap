namespace LinkedHeap.Tests
{
  /// <summary>
  /// Unit tests for <see cref="CustomHeap{T}"/> to verify allocation, freeing,
  /// expansion behavior, and event firing.
  /// </summary>
  [TestFixture]
  public unsafe class CustomHeapTests
  {
    /// <summary>
    /// The <see cref="CustomHeap{T}"/> we are testing.
    /// </summary>
    private CustomHeap<int>? _heap;

    /// <summary>
    /// Sets up a new <see cref="CustomHeap{T}"/> with small initial capacity before each test.
    /// </summary>
    [SetUp]
    public void Setup()
    {
      _heap = new CustomHeap<int>(initialCapacity: 2);
    }

    /// <summary>
    /// Disposes the heap after each test to free unmanaged memory.
    /// </summary>
    [TearDown]
    public void Teardown()
    {
      _heap?.Dispose();
      _heap = null;
    }

    /// <summary>
    /// Verifies that Allocate returns distinct non-zero pointers, marks them in-use,
    /// and fires OnAllocate exactly once per call.
    /// </summary>
    [Test]
    public void Allocate_ShouldReturnDistinctPointers_AndMarkNodesInUse()
    {
      var allocated = new List<IntPtr>();
      _heap!.OnAllocate += ptr => allocated.Add(ptr);

      // Allocate two nodes (initial capacity = 2)
      IntPtr ptr1 = _heap.Allocate(10);
      IntPtr ptr2 = _heap.Allocate(20);

      Assert.That(ptr1, Is.Not.EqualTo(IntPtr.Zero), "First allocation should not return IntPtr.Zero.");
      Assert.That(ptr2, Is.Not.EqualTo(IntPtr.Zero), "Second allocation should not return IntPtr.Zero.");
      Assert.That(ptr1, Is.Not.EqualTo(ptr2), "Two allocations should return distinct pointers.");

      Assert.That(allocated.Count, Is.EqualTo(2), "OnAllocate should fire exactly twice.");
      Assert.That(allocated, Has.Member(ptr1));
      Assert.That(allocated, Has.Member(ptr2));

      // Check node fields
      Assert.That(((HeapNode<int>*)ptr1)->Value, Is.EqualTo(10));
      Assert.That(((HeapNode<int>*)ptr2)->Value, Is.EqualTo(20));
      Assert.That(((HeapNode<int>*)ptr1)->InUse, Is.EqualTo(1), "Node must be marked InUse=1 after allocation.");
      Assert.That(((HeapNode<int>*)ptr2)->InUse, Is.EqualTo(1), "Node must be marked InUse=1 after allocation.");
    }

    /// <summary>
    /// Verifies that Free returns the node to the free list, fires OnFree,
    /// and that subsequent Allocate reuses the freed pointer.
    /// </summary>
    [Test]
    public void Free_ShouldReturnNodeToFreeList_AndFireOnFree()
    {
      var freed = new List<IntPtr>();
      _heap!.OnFree += ptr => freed.Add(ptr);

      IntPtr ptr = _heap.Allocate(42);
      _heap.Free(ptr);

      Assert.That(freed.Count, Is.EqualTo(1), "OnFree should fire exactly once.");
      Assert.That(freed[0], Is.EqualTo(ptr), "Freed pointer should match the one returned.");

      // After free, InUse should be 0
      Assert.That(((HeapNode<int>*)ptr)->InUse, Is.EqualTo(0), "Node should be marked InUse=0 after freeing.");

      // Allocating again should reuse that pointer
      IntPtr ptr2 = _heap.Allocate(99);
      Assert.That(ptr2, Is.EqualTo(ptr), "Freed node should be reused on next Allocate.");
    }

    /// <summary>
    /// Verifies that freeing <see cref="IntPtr.Zero"/> throws <see cref="InvalidOperationException"/>.
    /// </summary>
    [Test]
    public void Free_NullPointer_ShouldThrowInvalidOperationException()
    {
      Assert.That(() => _heap!.Free(IntPtr.Zero),
                  Throws.InvalidOperationException,
                  "Freeing IntPtr.Zero should throw InvalidOperationException.");
    }

    /// <summary>
    /// Verifies that double freeing the same pointer throws <see cref="InvalidOperationException"/>.
    /// </summary>
    [Test]
    public void Free_DoubleFree_ShouldThrowInvalidOperationException()
    {
      IntPtr ptr = _heap!.Allocate(5);
      _heap.Free(ptr);
      Assert.That(() => _heap.Free(ptr),
                  Throws.InvalidOperationException,
                  "Double freeing the same pointer should throw InvalidOperationException.");
    }

    /// <summary>
    /// Verifies that <see cref="CustomHeap{T}.GetAllNodes"/> returns exactly the correct number of pointers
    /// before and after expansion.
    /// </summary>
    [Test]
    public void GetAllNodes_ShouldReturnAllPointersAcrossBlocks()
    {
      // initialCapacity = 2, so first block has 2 nodes
      var allBefore = _heap!.GetAllNodes().ToList();
      Assert.That(allBefore.Count, Is.EqualTo(2), "Initial GetAllNodes should return exactly initialCapacity pointers.");

      // Allocate both nodes to exhaust the free list
      IntPtr a1 = _heap.Allocate(1);
      IntPtr a2 = _heap.Allocate(2);

      // Now free list is empty, next Allocate will cause expansion
      IntPtr a3 = _heap.Allocate(3); // triggers expansion to 4 total

      var allAfter = _heap.GetAllNodes().ToList();
      Assert.That(allAfter.Count, Is.EqualTo(4), "After expansion, GetAllNodes should return total number of nodes across both blocks.");
      Assert.That(allAfter.Distinct().Count(), Is.EqualTo(4), "GetAllNodes should return distinct pointers.");
    }

    /// <summary>
    /// Verifies that Allocate automatically expands the heap when the free list is empty.
    /// </summary>
    [Test]
    public void Allocate_ShouldAutomaticallyExpand_WhenFreeListEmpty()
    {
      // initial capacity = 2
      IntPtr p1 = _heap!.Allocate(100);
      IntPtr p2 = _heap.Allocate(200);
      // Now free list is empty; next allocation triggers expansion
      IntPtr p3 = _heap.Allocate(300);

      var all = _heap.GetAllNodes().ToList();
      Assert.That(all.Count, Is.EqualTo(4), "After expansion, total node count should be doubled to 4.");
      Assert.That(all, Has.Member(p3), "p3 should be among all nodes after expansion.");
    }
  }
}
