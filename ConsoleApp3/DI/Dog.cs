namespace ConsoleApp3.DI
{
  public class Dog : IEquality<Dog>
  {
    public int? Age { get; set; }
    public string? Specie { get; set; }
    public bool Equals(Dog? dog)
    {
      return (this.Age, this.Specie) == (dog?.Age, dog?.Specie);
    }
  }
}
