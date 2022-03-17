namespace ConsoleApp3
{
  internal class SumClass : ExpressionTime
  {
    public SumClass()
    {
    }

    public override string FirstAndLast(int[] nums)
    {
      return $"FirstElement:{nums[0]} LastElement{nums[nums.Length - 1]}";
    }
  }
}