namespace ConsoleApp3
{
  public class MinHeap : Heap
  {

    public MinHeap(int size) : base(size)
    {

    }

    public override void ReCalculateDown()
    {
      int index = 0;
      while (HasLeftChild(index))
      {
        var smallerIndex = GetLeftChildIndex(index);
        if (HasRightChild(index) && GetRightChild(index) < GetLeftChild(index))
        {
          smallerIndex = GetRightChildIndex(index);
        }

        if (_elements[smallerIndex] >= _elements[index])
        {
          break;
        }

        Swap(smallerIndex, index);
        index = smallerIndex;
      }
    }

    public override void ReCalculateUp()
    {
      var index = _size - 1;
      while (!IsRoot(index) && _elements[index] < GetParent(index))
      {
        var parentIndex = GetParentIndex(index);
        Swap(parentIndex, index);
        index = parentIndex;
      }
    }
  }
}

