namespace ConsoleApp3
{
  internal class Program
  {
    private static void Main(string[] args)
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
  }
}
