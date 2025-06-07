using Microsoft.AspNetCore.Components;

namespace LinkedHeap.Demo.Pages
{
  /// <summary>
  /// Code‐behind for <c>Index.razor</c>.
  /// Manages stack/queue controls, automated random operations, and rendering of heap nodes.
  /// </summary>
  public partial class Index : ComponentBase, IDisposable
  {
    /// <summary>
    /// All raw node pointers (one per allocated block, free or in‐use).
    /// </summary>
    private List<IntPtr> allNodes = [];

    /// <summary>
    /// Number to push onto the stack when "Push Value" is clicked.
    /// </summary>
    private int customStackValue = 0;

    /// <summary>
    /// Number to enqueue into the queue when "Enqueue Value" is clicked.
    /// </summary>
    private int customQueueValue = 0;

    /// <summary>
    /// Whether auto‐stack mode is enabled (random push/pop).
    /// </summary>
    private bool autoStack = false;

    /// <summary>
    /// Minimum millisecond delay between random stack actions.
    /// </summary>
    private int stackMinDelayMs = 100;

    /// <summary>
    /// Maximum millisecond delay between random stack actions.
    /// </summary>
    private int stackMaxDelayMs = 300;

    /// <summary>
    /// Whether auto‐queue mode is enabled (random enqueue/dequeue).
    /// </summary>
    private bool autoQueue = false;

    /// <summary>
    /// Minimum millisecond delay between random queue actions.
    /// </summary>
    private int queueMinDelayMs = 100;

    /// <summary>
    /// Maximum millisecond delay between random queue actions.
    /// </summary>
    private int queueMaxDelayMs = 300;

    /// <summary>
    /// Cancellation token source for the stack‐monitoring background loop.
    /// </summary>
    private CancellationTokenSource? ctsStack;

    /// <summary>
    /// Cancellation token source for the queue‐monitoring background loop.
    /// </summary>
    private CancellationTokenSource? ctsQueue;

    /// <summary>
    /// Current count of in‐use nodes.
    /// Computed whenever <see cref="RefreshHeap"/> is called.
    /// </summary>
    private int InUseCount { get; set; } = 0;

    /// <summary>
    /// The <see cref="IHeap{int}"/> instance resolved from DI.
    /// </summary>
    [Inject]
    public IHeap<int> MyHeap { get; set; } = default!;

    /// <summary>
    /// The <see cref="IStack{int}"/> instance resolved from DI, backed by the same unmanaged heap.
    /// </summary>
    [Inject]
    public IStack<int> MyStack { get; set; } = default!;

    /// <summary>
    /// The <see cref="IQueue{int}"/> instance resolved from DI, backed by the same unmanaged heap.
    /// </summary>
    [Inject]
    public IQueue<int> MyQueue { get; set; } = default!;

    #region Lifecycle

    /// <summary>
    /// Called when the component is initialized. Hooks heap events and starts background loops.
    /// </summary>
    protected override void OnInitialized()
    {
      // Subscribe to heap allocate/free to refresh UI
      MyHeap.OnAllocate += _ => RefreshHeap();
      MyHeap.OnFree += _ => RefreshHeap();
      RefreshHeap();

      // Start the stack loop
      ctsStack = new CancellationTokenSource();
      _ = MonitorStackAsync(ctsStack.Token);

      // Start the queue loop
      ctsQueue = new CancellationTokenSource();
      _ = MonitorQueueAsync(ctsQueue.Token);
    }

    /// <summary>
    /// Dispose of cancellation token sources when the component is destroyed.
    /// </summary>
    public void Dispose()
    {
      ctsStack?.Cancel();
      ctsQueue?.Cancel();
      GC.SuppressFinalize(this);
    }

    #endregion

    #region Heap Refresh

    /// <summary>
    /// Re‐reads all raw node pointers and updates <see cref="allNodes"/> and <see cref="InUseCount"/>.
    /// Triggers a UI re‐render.
    /// </summary>
    private void RefreshHeap()
    {
      allNodes = [.. MyHeap.GetAllNodes()];
      InUseCount = allNodes.Count(IsInUse);
      InvokeAsync(StateHasChanged);
    }

    #endregion

    #region Stack Operations

    /// <summary>
    /// Pushes a single <paramref name="value"/> onto the stack.
    /// Fired when "Push Value" button is clicked.
    /// </summary>
    /// <param name="value">The integer to push onto <see cref="MyStack"/>.</param>
    private void Push(int value)
    {
      MyStack.Push(value);
    }

    /// <summary>
    /// Pops the top element from <see cref="MyStack"/> if not empty.
    /// Fired when “Pop” button is clicked.
    /// </summary>
    private void PopStack()
    {
      if (!MyStack.IsEmpty)
        MyStack.Pop();
    }

    /// <summary>
    /// Background loop that, while <paramref name="token"/> is not canceled:
    /// – Randomly chooses to push or pop (50/50) if <see cref="autoStack"/>
    /// – Waits a random delay between <see cref="stackMinDelayMs"/> and <see cref="stackMaxDelayMs"/> ms
    /// </summary>
    /// <param name="token">Cancellation token for stopping the loop.</param>
    private async Task MonitorStackAsync(CancellationToken token)
    {
      var rnd = new Random();
      while (!token.IsCancellationRequested)
      {
        if (autoStack)
        {
          // 50% chance to Push a random value; otherwise Pop if possible
          if (rnd.NextDouble() < 0.5)
          {
            int val = rnd.Next(0, 100);
            MyStack.Push(val);
          }
          else if (!MyStack.IsEmpty)
          {
            MyStack.Pop();
          }
        }

        // Wait a random interval
        int delay = rnd.Next(stackMinDelayMs, stackMaxDelayMs + 1);
        try
        {
          await Task.Delay(delay, token);
        }
        catch (TaskCanceledException)
        {
          return;
        }
      }
    }

    #endregion

    #region Queue Operations

    /// <summary>
    /// Enqueues a single <paramref name="value"/> into <see cref="MyQueue"/>.
    /// Fired when “Enqueue Value” button is clicked.
    /// </summary>
    /// <param name="value">The integer to enqueue.</param>
    private void Enqueue(int value)
    {
      MyQueue.Enqueue(value);
    }

    /// <summary>
    /// Dequeues the front element from <see cref="MyQueue"/> if not empty.
    /// Fired when “Dequeue” button is clicked.
    /// </summary>
    private void DequeueQueue()
    {
      if (!MyQueue.IsEmpty)
        MyQueue.Dequeue();
    }

    /// <summary>
    /// Background loop that, while <paramref name="token"/> is not canceled:
    /// – Randomly chooses to enqueue or dequeue (50/50) if <see cref="autoQueue"/>
    /// – Waits a random delay between <see cref="queueMinDelayMs"/> and <see cref="queueMaxDelayMs"/> ms
    /// </summary>
    /// <param name="token">Cancellation token for stopping the loop.</param>
    private async Task MonitorQueueAsync(CancellationToken token)
    {
      var rnd = new Random();
      while (!token.IsCancellationRequested)
      {
        if (autoQueue)
        {
          // 50% chance to Enqueue a random value; otherwise Dequeue if possible
          if (rnd.NextDouble() < 0.5)
          {
            int val = rnd.Next(0, 100);
            MyQueue.Enqueue(val);
          }
          else if (!MyQueue.IsEmpty)
          {
            MyQueue.Dequeue();
          }
        }

        // Wait a truly random interval
        int delay = rnd.Next(queueMinDelayMs, queueMaxDelayMs + 1);
        try
        {
          await Task.Delay(delay, token);
        }
        catch (TaskCanceledException)
        {
          return;
        }
      }
    }

    #endregion

    #region Pointer Helpers (unsafe)

    /// <summary>
    /// Reads the raw <see cref="HeapNode{T}.InUse"/> byte from unmanaged memory and returns true if allocated.
    /// </summary>
    /// <param name="ptr">Pointer (as <see cref="IntPtr"/>) to a <see cref="HeapNode{int}"/>.</param>
    /// <returns><c>true</c> if this node’s InUse flag is 1; otherwise <c>false</c>.</returns>
    private unsafe bool IsInUse(IntPtr ptr)
    {
      return ((HeapNode<int>*)ptr)->InUse == 1;
    }

    /// <summary>
    /// Reads the raw <see cref="HeapNode{T}.Value"/> from unmanaged memory.
    /// </summary>
    /// <param name="ptr">Pointer (as <see cref="IntPtr"/>) to a <see cref="HeapNode{int}"/>.</param>
    /// <returns>The integer payload stored in that node.</returns>
    private unsafe int GetValue(IntPtr ptr)
    {
      return ((HeapNode<int>*)ptr)->Value;
    }

    /// <summary>
    /// Reads the raw <see cref="HeapNode{T}.Next"/> pointer from unmanaged memory.
    /// </summary>
    /// <param name="ptr">Pointer (as <see cref="IntPtr"/>) to a <see cref="HeapNode{int}"/>.</param>
    /// <returns>
    /// A <see cref="HeapNode{int}*"/> pointing to the next node (free‐list or stack/queue link),
    /// or <c>null</c>.
    /// </returns>
    private unsafe HeapNode<int>* GetNext(IntPtr ptr)
    {
      return ((HeapNode<int>*)ptr)->Next;
    }

    #endregion
  }
}
