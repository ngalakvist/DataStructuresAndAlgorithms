namespace ConsoleApp3
{
  using System.Linq;
  public abstract class ExpressionTime
  {
    public int Count(int[] nums)
    {
      var sum = nums.Aggregate((x, y) => x + y);
      return sum;
    }
    public abstract string FirstAndLast(int[] nums);

  }
}