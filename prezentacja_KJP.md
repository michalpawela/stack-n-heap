---
title: Realizacja stosu i kolejki na listach wskaźnikowych  
author: Hieronim Daniel, Michał Pawela
---

<!-- new_lines: 10 -->
<!-- incremental_lists: true -->
## Cel i motywacja

- Standardowe implementacje stosu i kolejki w C# wykorzystują tablice lub kolekcje .NET.  
- Użycie wskaźników (`unsafe`) pozwala na pełną kontrolę alokacji i zwalniania węzłów.  
- **Problem**: jak stworzyć stos i kolejkę w pamięci niezarządzanej z dynamiczną alokacją/zwalnianiem węzłów, bez fragmentacji i z możliwością ponownego użycia wolnego miejsca?
<!-- incremental_lists: false -->
<!-- end_slide -->

<!-- new_lines: 10 -->
## Definicje podstawowe

<!-- incremental_lists: true -->
- **Stos (LIFO)** – struktura, w której ostatni dodany element jest usuwany jako pierwszy.  
- **Kolejka (FIFO)** – struktura, w której pierwszy dodany element jest usuwany jako pierwszy.  
- **Węzeł (node)** – element przechowujący wartość oraz wskaźnik na następny węzeł.  
- **Menedżer sterty (allocator)** – kod odpowiedzialny za *alokację* i *zwalnianie* bloków pamięci w obszarze unmanaged.  
- **Free‑lista** – jednokierunkowa lista wskaźników prowadząca przez wszystkie *wolne* węzły, gotowe do ponownego użycia.  
<!-- incremental_lists: false -->
<!-- end_slide -->

## Jak działają stosy i kolejki?
<!-- pause -->

<!-- column_layout: [2, 2] -->
<!-- column: 0 -->
### Stos (LIFO – Last In First Out)

```text
stos pusty
┌──────────────┐
│   początek   │  TOP → ∅  
└──────────────┘
```

```
 ▄▄▄  push(3)
┌───┐
│ 3 │  TOP → 3
└─┬─┘
  ▼
  ∅
```

```
 ▄▄▄  push(5)
┌───┐
│ 5 │  TOP → 5
└─┬─┘
  ▼
┌───┐
│ 3 │
└───┘
```

```
 ▄▄▄  pop() ⇒ 5
┌───┐
│ 3 │  TOP → 3
└───┘
```

*Element dodany ostatni (`5`) wychodzi pierwszy – klasyczne **LIFO**.*

<!-- pause -->

<!-- column: 1 -->
### Kolejka (FIFO – First In First Out)

```text
kolejka pusta
┌──────────────┐
│   początek   │  HEAD → ∅ ,  TAIL → ∅  
└──────────────┘
```

```
 ▄▄▄  enqueue(3)
HEAD , TAIL
   │
   ▼
┌───┐
│ 3 │
└───┘
```

```
 ▄▄▄  enqueue(5)
HEAD                TAIL
  │                   │
  ▼                   ▼
┌───┐ ─────────────▶ ┌───┐
│ 3 │                │ 5 │
└───┘                └───┘
```

```
 ▄▄▄  dequeue() ⇒ 3
HEAD , TAIL
   │
   ▼
┌───┐
│ 5 │
└───┘
```

*Kolejka zwraca element dodany najwcześniej (`3`) – klasyczne **FIFO**.*
<!-- end_slide -->

<!-- new_lines: 10 -->
## Dlaczego własny menedżer sterty?

<!-- incremental_lists: true -->
- **Brak GC** → przewidywalne czasy operacji, ważne w RTOS / grach / systemach wbudowanych.  
- **Kontrola układu pamięci** → możliwe *cache‑friendly* rozmieszczenie węzłów.  
- **Eliminacja fragmentacji** → wszystkie węzły mają jednakowy rozmiar, więc nigdy nie powstają „dziury”.  
- **Zdarzenia alokacji/zwolnienia** → łatwe profilowanie i wizualizacja (demo Blazor).  
<!-- incremental_lists: false -->
<!-- end_slide -->

<!-- new_lines: 10 -->
<!-- incremental_lists: true -->
## Wyzwania

1. **Reprezentacja węzłów w pamięci unmanaged** – brak Garbage Collectora, operujemy bezpośrednio na wskaźnikach.  
2. **Zarządzanie pulą wolnych węzłów (free‑lista)** – szybkie znajdowanie wolnego elementu i wstawianie go z powrotem po zwolnieniu.  
3. **Ekspansja puli** – alokacja nowych bloków (podwajanie rozmiaru) i scalanie z istniejącą free‑listą.  
4. **Bezpieczne zwalnianie** – ochrona przed wyciekami pamięci i podwójnym `Free`.  
5. **Integracja z C#, DI i zdarzeniami** – wygodne użycie w kodzie zarządzanym (np. Blazor), wizualizacja.  
<!-- incremental_lists: false -->
<!-- end_slide -->

<!-- jump_to_middle -->
<!-- no_footer -->
<!-- alignment: center -->
# Implementacja  
w projekcie **LinkedHeap**
<!-- end_slide -->

<!-- new_lines: 10 -->
## Menedżer sterty `CustomHeap<T>`

```csharp +line_numbers 
public unsafe struct HeapNode<T> where T : unmanaged
{
    public T Value;            // Przechowywana wartość
    public HeapNode<T>* Next;  // Wskaźnik: free‑lista lub link stos/kolejka
    public byte InUse;         // 1 = zajęty, 0 = wolny
}
```

<!-- pause -->

* Bloki węzłów rosną wykładniczo: **1 → 2 → 4 → 8 …**  
* Każdy nowy blok **wstawia się na początek** free‑listy.  
* Operacje **`Allocate` / `Free`** są stałoczasowe (`O(1)`) i nie generują fragmentacji (wszędzie identyczny rozmiar węzła).  
* Struktura `HeapNode<T>` to *Plain Old Data* → brak ukrytych pól, łatwy memcpy.  
<!-- end_slide -->

<!-- new_lines: 10 -->
## Struktura pamięci

```text
╔══════ Block 1 (4 węzłów) ═════╗   ⇐ nowy blok (najświeższy)
║ Node4 Node5 Node6 Node7       ║
╚═══════════════════════════════╝
                  │
                  ▼
freeListHead ─▶ Node4 ─▶ Node5 ─▶ Node6 ─▶ Node7 ─▶
                                        │
                                        ▼
╔══════ Block 0 (2 węzłów) ═════╗   ⇐ wcześniejszy blok
║ Node0 Node1                   ║
╚═══════════════════════════════╝
             └───────── … ─────────▶ null
```

*Nowy blok jest **doklejany z przodu** – dzięki temu kolejne `Allocate` trafiają w rosnące adresy.*

<!-- end_slide -->

<!-- new_lines: 10 -->
## Algorytm `Allocate`

<!-- column_layout: [2, 2] -->
<!-- column: 0 -->

```csharp +line_numbers 

    public IntPtr Allocate(T value)
    {
      if (_freeListHead == null)
      {
        // No free nodes remain: allocate a new block (double size)
        AllocateBlock(_nextBlockCapacity);
        _nextBlockCapacity *= 2;
      }

      // Pop one node from the free‐list
      HeapNode<T>* node = _freeListHead;
      _freeListHead = node->Next;

      // Initialize the node
      node->Value = value;
      node->Next = null;
      node->InUse = 1;

      nint ptr = new(node);
      OnAllocate(ptr);
      return ptr;
    }

```

<!-- column: 1 -->

<!-- incremental_lists: true -->
1. Brak wolnych węzłów? → alokuj nowy blok (_podwój rozmiar_).  
2. Zdejmij pierwszy węzeł z free‑listy.  
3. Wypełnij pola:  
   - `Value = value`  
   - `InUse = 1`  
   - `Next = null`  
4. Zwróć `IntPtr` i wywołaj **`OnAllocate(ptr)`**.  
<!-- incremental_lists: false -->

<!-- end_slide -->

<!-- new_lines: 10 -->
## Algorytm `Free`

<!-- column_layout: [2, 2] -->
<!-- column: 0 -->

```csharp +line_numbers 
    public void Free(IntPtr nodePtr)
    {
      if (nodePtr == IntPtr.Zero)
      {
        throw new InvalidOperationException("Cannot free a null pointer.");
      }

      var node = (HeapNode<T>*)nodePtr;
      if (node->InUse == 0)
      {
        throw new InvalidOperationException("Node is already freed.");
      }

      node->InUse = 0;
      node->Next = _freeListHead;
      _freeListHead = node;

      OnFree(nodePtr);
    }

```

<!-- column: 1 -->

<!-- incremental_lists: true -->
1. Walidacja: `ptr != 0` *i* `InUse == 1`.  
2. `InUse = 0`.  
3. `node->Next = freeListHead`.  
4. `freeListHead = node`.  
5. **`OnFree(ptr)`** – subskrybenci mogą reagować np. odświeżeniem UI.  
<!-- incremental_lists: false -->
<!-- end_slide -->

<!-- new_lines: 10 -->
## Szczegóły `HeapStack<T>` (Push / Pop)

<!-- column_layout: [2, 2] -->
<!-- column: 0 -->
```csharp +line_numbers
nint ptr = _heap.Allocate(value);
var node = (HeapNode<T>*)ptr;

node->Next = _top;
_top = node;
```

<!-- column: 1 -->

<!-- incremental_lists: true -->

1. **Push**

   * Alokacja nowego węzła z wartością
   * Przypisanie `node->Next` do poprzedniego szczytu
   * Ustawienie `Top = node`

<!-- reset_layout -->

<!-- column_layout: [2, 2] -->
<!-- column: 0 -->

```csharp +line_numbers
if (_top == null)
  throw new Exception;

HeapNode<T>* node = _top;
T result = node->Value;
_top = node->Next;

_heap.Free(new IntPtr(node));
return result;
````

<!-- column: 1 -->
2. **Pop**

   * Sprawdzenie, czy stos nie jest pusty
   * Przesunięcie `Top` na `oldTop->Next`
   * Zwalnianie pamięci `oldTop` w heapie

<!-- new_lines: 3 -->
3. **Koszt operacji:** każda z metod wykonuje stałą liczbę kroków → **O(1)**
4. **Pamięć:** dokładnie jeden węzeł na każdy element


<!-- incremental_lists: false -->

<!-- reset_layout -->

<!-- end_slide -->

<!-- new_lines: 10 -->
## Kolejka `HeapQueue<T>` – szczegóły

<!-- incremental_lists: true -->
- **Enqueue** – amortyzowane `O(1)` (stałoczasowo oprócz okazjonalnej ekspansji sterty):  
```csharp
tail->Next = newNode
tail = newNode
```  
  *Jeśli kolejka była pusta – dodatkowo `_head = newNode`.*  
- **Dequeue** – `O(1)` :  
```csharp
oldHead = _head
_head   = _head->Next
if(_head == null) _tail = null
heap.Free(oldHead)
```  
- **Koszt pamięci**: 1 węzeł na element.  
<!-- incremental_lists: false -->
<!-- end_slide -->

<!-- new_lines: 10 -->
## Warstwa usługowa & DI

<!-- alignment: center -->
```csharp +line_numbers
builder.Services.AddLinkedHeapServices<int>();
```
<!-- alignment: left -->

<!-- pause -->

- `LinkedHeapService<T>` tworzy pojedynczą instancję **heap/stack/queue** na cały proces.  
- Wzorzec **Service Locator** zapewnia, że **każdy komponent** pracuje na *tej samej* stercie → obserwujemy wspólny stan.  
- Dzięki zdarzeniom `OnAllocate`/`OnFree`/`OnChanged` komponent Blazor może wizualizować układ pamięci *w czasie rzeczywistym*.  
<!-- end_slide -->

<!-- new_lines: 10 -->
<!-- incremental_lists: true -->
## Podsumowanie

* **100 % kontrola pamięci** – brak GC.  
* **Brak fragmentacji** – wszystkie elementy mają identyczny rozmiar.  
* **Stałoczasowe operacje** – `Allocate`, `Free`, `Push`, `Pop`, `Enqueue`, `Dequeue`.  
* **Automatyczna ekspansja** – brak limitu pojemności.  
* **Przyjazne API** – interfejsy + DI + zdarzenia.  
* **Demo Blazor** – edukacyjna wizualizacja sterty w przeglądarce.  
<!-- incremental_lists: false -->
<!-- end_slide -->

<!-- no_footer -->
<!-- jump_to_middle -->
<!-- alignment: center -->
# Dziękujemy  
_Pytania?_
<!-- end_slide -->
