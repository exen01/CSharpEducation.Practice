namespace Practice5.Task1
{
  internal class Manager : Employee
  {
    public Manager(string name, int salary, int teamSize) : base(name, salary)
    {
      TeamSize = teamSize;
    }

    public int TeamSize { get; set; }

    public override double CalculateBonus()
    {
      double bonus = 0;
      if (TeamSize > 5)
      {
        bonus = (Salary / 100) * (20 + 5);
      }
      else
      {
        bonus = (Salary / 100) * 20;
      }

      return bonus;
    }
  }
}
