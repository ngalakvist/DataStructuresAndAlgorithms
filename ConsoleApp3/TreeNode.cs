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

    /// <summary>
    /// Insert.
    /// </summary>
    /// <param name="value"></param>
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

    /// <summary>
    /// Contains
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool Contains(int value)
    {
      if (Data == value)
        return true;
      if (Left == null && Right == null)
        return false;
      if (value < Data)
        return Left.Contains(value);
      else
      if (value > Data)
        return Right.Contains(value);

      return false;
    }


    /// <summary>
    /// Print
    /// </summary>

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
