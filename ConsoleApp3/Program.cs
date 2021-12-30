using System;

namespace ConsoleApp3
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var arr = new int[] { 4, 2, 1, 7, 8, 1, 2, 8, 1, 0 };
      /*
            Example 1:
         Input: nums = [1, 2, 3, 1]
         Output: 4
         Explanation: Rob house 1(money = 1) and then rob house 3(money = 3).
         Total amount you can rob = 1 + 3 = 4.
         Example 2:
         Input: nums = [2, 7, 9, 3, 1]
         Output: 12 */

      var nums = new int[] { 1, 2, 3, 1 };
      var length = nums.Length;
      var memo = new int[length + 1];
      var max = new DynamicProgramming().RobHouse(nums, length, memo);
      Console.WriteLine("The max money is: " + max);
      Console.ReadLine();
    }

    private static void TreeNodeHandler()
    {
      var tree = new TreeNode(10);
      tree.Insert(9);
      tree.Insert(5);
      tree.Insert(2);
      tree.Insert(11);
      tree.Insert(19);
      tree.Insert(20);
      System.Console.WriteLine("Print Inorder");
      tree.PrintInOrder();
    }

    private static void GraphClient()
    {
      Graph graph = new Graph();
      graph.addVertex("A");
      graph.addVertex("B");
      graph.addVertex("C");
      graph.addVertex("D");
      graph.addVertex("E");
      graph.addVertex("F");
      graph.addVertex("G");

      graph.addEdge("A", "B", 1);
      graph.addEdge("A", "D", 3);
      graph.addEdge("B", "C", 4);
      graph.addEdge("D", "F", 6);
      graph.addEdge("E", "F", 10);
      graph.addEdge("E", "G", 11);
      graph.addEdge("F", "G", 17);
      graph.addEdge("G", "A", 111);

      graph.display();
      graph.removeEdge("A");

      graph.display();
    }

    /// <summary>
    /// Sliding window teknik
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="k"></param>
    /// <returns></returns>

    public static int MaxSumSubArray(int[] arr, int k)
    {
      // Check inputs

      var max = int.MinValue;
      int currentRunningSum = 0;

      for (int i = 0; i < arr.Length; i++)
      {
        currentRunningSum += arr[i];
        int realIndex = k - 1;
        if (i >= realIndex)
        {
          max = Math.Max(max, currentRunningSum);
          currentRunningSum -= arr[i - realIndex];
        }

      }
      return max;
    }


    public static void PrintSubSets(string s)
    {
      PrintSubSets("", s);

    }

    public static void PrintSubSets(string sofar, string rest)
    {
      if (rest == "")
      {
        Console.WriteLine(sofar);
      }
      else
      {
        PrintSubSets(sofar + rest[0], rest.Substring(1));
        PrintSubSets(sofar, rest.Substring(1));
      }
    }


    public static void PrintPermutions(string s)
    {
      PrintPermutions("", s);
    }
    private static void PrintPermutions(string prefix, string remainder)
    {
      if (remainder == "")
      {
        Console.WriteLine(prefix);
      }
      else
      {
        var len = remainder.Length;
        for (int i = 0; i < len; i++)
        {
          string before = remainder.Substring(0, i);
          char current = remainder[i];
          var start = i + 1;
          var nyLength = len - start;
          string after = remainder.Substring(i + 1, nyLength);
          PrintPermutions(prefix + current, before + after);
        }

      }
    }

  }

}


