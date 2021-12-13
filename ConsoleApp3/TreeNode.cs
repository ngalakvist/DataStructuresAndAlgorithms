namespace ConsoleApp3
{
  /// <summary>
  /// Binary Tree
  /// </summary>
  public class TreeNode
  {
    public int Data;
    public TreeNode Left = null;
    public TreeNode Right = null;
    public TreeNode(int value)
    {
      this.Data = value;
    }

    public void Insert(int value)
    {
      if (value <= Data)
      {
        if (Left == null)
          Left = new TreeNode(value);
        else
          Left.Insert(value);
      }
      else
      {
        if (Right == null)
          Right = new TreeNode(value);
        else
          Right.Insert(value);
      }
    }

    public void PrintInOrder()
    {
      if (Left != null)
        Left.PrintInOrder();
      System.Console.Write($"{Data}, ");
      if (Right != null)
        Right.PrintInOrder();
    }
  }
}
