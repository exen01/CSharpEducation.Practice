namespace Practice5.Task1
{
  internal class Manager : Employee
  {
    public override double CalculateBonus()
    {
      return (Salary / 100) * 20;
    }
  }
}
