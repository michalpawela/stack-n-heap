# LinkedHeap

A C# library providing a custom unmanaged‐memory heap manager, along with unsafe stack and queue implementations backed by pointers. Includes:

* **CustomHeap\<T>**: A pointer‐based heap allocator for unmanaged value types.
* **HeapStack\<T> & HeapQueue\<T>**: LIFO and FIFO collections that allocate nodes from the custom heap.
* **LinkedHeapService\<T>**: A DI‐friendly wrapper that exposes a single heap, stack, and queue as injectable services.
* **Blazor Demo**: A WebAssembly sample that visualizes heap blocks, stack, and queue operations in real time.

> **Warning:** All heap, stack, and queue classes use `unsafe` code and allocate unmanaged memory. You must enable `<AllowUnsafeBlocks>true</AllowUnsafeBlocks>` in your project file.

---

## Table of Contents

1. [Features](#features)
2. [Getting Started](#getting-started)

   * [Prerequisites](#prerequisites)
   * [Installation](#installation)
   * [Building from Source](#building-from-source)
3. [Usage](#usage)

   * [Creating a `CustomHeap<T>`](#creating-a-customheapt)
   * [Using `HeapStack<T>` and `HeapQueue<T>`](#using-heapstackt-and-heapqueuet)
---

## Features

* **Pointer‐Based Heap**

  * Manages unmanaged `HeapNode<T>` blocks in native (heap) memory.
  * Automatically doubles capacity when the free list is exhausted.
  * Fires events (`OnAllocate` / `OnFree`) whenever a node is allocated or freed.

* **Unsafe Stack & Queue**

  * `HeapStack<T>` (LIFO) and `HeapQueue<T>` (FIFO) use raw pointers for linkage.
  * Exposes node pointers as `IntPtr`, allowing external inspection or visualization.
  * Events (`OnChanged`) fire on `Push`/`Pop` or `Enqueue`/`Dequeue`.
  * Under the hood, nodes are always allocated/freed from the same `CustomHeap<T>`.

* **Dependency‐Injection Support**

  * `LinkedHeapService<T>` wraps one heap, one stack, and one queue.
  * `AddLinkedHeapServices<T>()` extension registers `IHeap<T>`, `IStack<T>`, and `IQueue<T>` as singletons in `IServiceCollection`.

* **Blazor WebAssembly Demo**

  * Provides a live web UI that visualizes all heap nodes in a grid (colored by in‐use vs. free).
  * Lets you perform random or manual `Push`/`Pop`, `Enqueue`/`Dequeue` operations.
  * Configurable random intervals with jitter.

* **Unit Tests (NUnit)**

  * Comprehensive coverage for heap expansion, allocation, freeing, reuse, and error cases.
  * Tests for stack & queue ordering, event firing, and node‐reuse behavior.

---

## Getting Started

### Prerequisites

* [.NET 10.0 SDK (Preview)](https://dotnet.microsoft.com/download/dotnet/10.0)
* A code editor or IDE that supports C# 10 / .NET 10 (e.g., Visual Studio 2022, Rider, VS Code, Neovim with [roslyn.nvim](https://github.com/seblyng/roslyn.nvim) plugin).
* For Blazor Demo: Modern web browser (Chrome, Edge, Firefox, Safari).

> All projects target **net10.0**. Make sure your `dotnet --version` is a 10.0 preview (e.g., `10.0.100-preview.xxxx`).

### Installation

   Clone this repository and build locally:

   ```bash
   git clone https://github.com/Hier0nim/LinkedHeap.git
   cd LinkedHeap
   dotnet build
   ```

   * The library (`LinkedHeap/`) will compile to `bin/Debug/net10.0/LinkedHeap.dll` by default.
   * Unit tests live under `LinkedHeap.Tests/`.
   * A Blazor Demo is under `LinkedHeap.Demo/`.

### Building from Source

```bash
# From the repository root
dotnet restore
dotnet build   # Builds Library, Tests, and Demo
dotnet test    # Runs all NUnit tests
cd LinkedHeap.Demo
dotnet run     # Launches Blazor WASM demo (https://localhost:7106)
```

---

## Usage

### Creating a `CustomHeap<T>`

```csharp
using System;
using LinkedHeap;

public class Example
{
    public static void Main()
    {
        // Create a heap for unmanaged int nodes, with an initial capacity of 1024 nodes
        using var heap = new CustomHeap<int>(initialCapacity: 1024);

        // Subscribe to allocation / free events
        heap.OnAllocate += ptr => Console.WriteLine($"Allocated node at 0x{ptr.ToString("X")}");
        heap.OnFree     += ptr => Console.WriteLine($"Freed node  at 0x{ptr.ToString("X")}");

        // Allocate two int nodes
        IntPtr nodeA = heap.Allocate(42);
        IntPtr nodeB = heap.Allocate(100);

        // Read value directly from the node (unsafe)
        unsafe
        {
            var rawNodeA = (HeapNode<int>*)nodeA;
            Console.WriteLine($"Value at nodeA: {rawNodeA->Value}");  // 42
        }

        // Free them
        heap.Free(nodeA);
        heap.Free(nodeB);
    }
}
```

### Using `HeapStack<T>` and `HeapQueue<T>`

```csharp
using System;
using System.Collections.Generic;
using LinkedHeap;

public class StackQueueDemo
{
    public static void Main()
    {
        using var heap  = new CustomHeap<int>(initialCapacity: 4);
        var     stack = new HeapStack<int>(heap);
        var     queue = new HeapQueue<int>(heap);

        // Subscribe to stack/queue change events
        stack.OnChanged += () => Console.WriteLine("Stack changed");
        queue.OnChanged += () => Console.WriteLine("Queue changed");

        // Push/pop on the stack
        stack.Push(1);
        stack.Push(2);
        Console.WriteLine($"Stack peek: {stack.Peek()}"); // 2
        int popped = stack.Pop();                       // pops 2

        // Enqueue/dequeue in the queue
        queue.Enqueue(10);
        queue.Enqueue(20);
        Console.WriteLine($"Queue peek: {queue.Peek()}"); // 10
        int dequeued = queue.Dequeue();                  // dequeues 10

        // Enumerate all node pointers (heap.GetAllNodes()) if you wish to inspect the entire heap
        IEnumerable<IntPtr> allPtrs = heap.GetAllNodes();
        foreach (var ptr in allPtrs)
        {
            unsafe
            {
                var node = (HeapNode<int>*)ptr;
                Console.WriteLine($"Ptr=0x{ptr.ToString("X")}, InUse={node->InUse}, Value={node->Value}");
            }
        }
    }
}
```
