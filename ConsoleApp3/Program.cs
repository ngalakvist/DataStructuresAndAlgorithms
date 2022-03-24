using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
  internal class Program
  {

    private static void Main(string[] args)
    {

      var arr = new int[] { 1, 1, 1, 2, 2, 2, 3, 4, 5, 6, 8, 8, 8, 8, 9999 };
      CountOccurance(arr);
      CountOccuranceUsingGroup(arr);
      Console.ReadLine();
    }


    private static void BuildAHashTableUsingCharArrays(string s)
    {
      var str = s.ToCharArray();
      int NUMBEROFALFABETS_ENGLISH = 26;
      var arrVal = new int[NUMBEROFALFABETS_ENGLISH];
      for (int i = 0; i < str.Length; i++)
      {
        var index = str[i] - 'a';
        arrVal[index]++;
      }
      for (int i = 0; i < NUMBEROFALFABETS_ENGLISH; i++)
      {
        Console.WriteLine($"{str[i]}:{arrVal[i] }");
      }
    }

    private static void DynamicPrograming()
    {
      /*  Example 1:
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

    /// <summary>
    /// Print Permutations
    /// </summary>
    /// <param name="s"></param>
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


    /// <summary>
    /// Two sum
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
    ///You can return the answer in any order.
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int[] TwoSum(int[] nums, int target)
    {
      if (nums == null)
        return null;
      int[] result = new int[1];
      Dictionary<int, int> dict = new Dictionary<int, int>();

      for (int i = 0; i < nums.Length; i++)
      {
        int comp = target - nums[i];
        if (dict.ContainsKey(comp))
        {
          int value;
          dict.TryGetValue(comp, out value);
          result = new int[] { value, i };
          return result;
        }
        if (!dict.ContainsKey(nums[i]))
          dict.Add(nums[i], i);
      }
      return null;
    }

    /// <summary>
    ///  Generate subsets
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static List<List<int>> GetSubsets(int[] nums)
    {
      List<List<int>> subsets = new List<List<int>>();
      int[] first = { };
      subsets.Add(new List<int>(first));
      foreach (var item in nums)
      {
        var currentResultSubsetSize = subsets.Count;
        for (int i = 0; i < currentResultSubsetSize; i++)
        {
          var nextList = new List<int>(subsets[i]);
          nextList.Add(item);
          subsets.Add(nextList);
        }

      }
      return subsets;
    }

    public static void CountOccurance(int[] nums)
    {
      var dict = new Dictionary<int, int>();
      var max = int.MinValue;
      foreach (var item in nums)
      {
        if (dict.ContainsKey(item))
        {
          dict[item] = dict[item] + 1;
        }
        else
          dict.Add(item, 1);
        max = Math.Max(max, dict[item]);
      }
      dict.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
      Console.WriteLine("The max value is: " + max);
    }


    public static void CountOccuranceUsingGroup(int[] nums)
    {
      var theDict = nums.GroupBy(num => num).ToDictionary(n => n.Key, n => n.Count());
      theDict.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
    }
  }
}



