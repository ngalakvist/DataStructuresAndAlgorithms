using System;

namespace ConsoleApp3
{
  /// <summary>
  /// Heap Datastructure
  /// </summary>
  public abstract class Heap
  {
    protected readonly int[] _elements;
    protected int _size;

    public Heap(int size)
    {
      _elements = new int[size];
    }

    public int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
    public int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;
    public int GetParentIndex(int elementIndex) => (elementIndex - 1) / 2;

    public bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < _size;
    public bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < _size;
    public bool IsRoot(int elementIndex) => elementIndex == 0;

    public int GetLeftChild(int elementIndex) => _elements[GetLeftChildIndex(elementIndex)];
    public int GetRightChild(int elementIndex) => _elements[GetRightChildIndex(elementIndex)];
    public int GetParent(int elementIndex) => _elements[GetParentIndex(elementIndex)];

    public void Swap(int firstIndex, int secondIndex)
    {
      var temp = _elements[firstIndex];
      _elements[firstIndex] = _elements[secondIndex];
      _elements[secondIndex] = temp;
    }

    public bool IsEmpty()
    {
      return _size == 0;
    }

    public int Peek()
    {
      if (_size == 0)
        throw new IndexOutOfRangeException();

      return _elements[0];
    }

    public int Pop()
    {
      if (_size == 0)
        throw new IndexOutOfRangeException();

      var result = _elements[0];
      _elements[0] = _elements[_size - 1];
      _size--;

      ReCalculateDown();

      return result;
    }

    public void Add(int element)
    {
      if (_size == _elements.Length)
        throw new IndexOutOfRangeException();

      _elements[_size] = element;
      _size++;

      ReCalculateUp();
    }
    /// <summary>
    /// MaxHeap calc
    /// </summary>

    public abstract void ReCalculateDown();

    /// <summary>
    /// MAx heap Calc
    /// 
    /// </summary>
    public abstract void ReCalculateUp();

  }
}
