using System.Collections.Generic;

namespace ConsoleApp3
{
  public class CollectionsInCCharp
  {
    private int[] nums;
    private List<string> words;
    private Dictionary<int, string> map;
    public class MinIntHeap
    {
      private static int capacity = 50;
      private int size = 0;
      private int[] items = new int[capacity];

      private int GetLeftChildIndex(int parentIndex) { return 2 * parentIndex + 1; }
      private int GetRightChildIndex(int parentIndex) { return 2 * parentIndex + 2; }

      private int GetParentIndex(int childIndex) { return (childIndex - 1) / 2; }
    }
  }
}
