namespace Practice5.Task1
{
  internal class Contractor : Employee
  {
    public int HourlyRate { get; set; }
    
    public Contractor(string name, int salary, int hourlyRate) : base(name, salary)
    {
      HourlyRate = hourlyRate;
    }

    public new double CalculateBonus(int hoursWorked)
    {
      return Salary * hoursWorked;
    }
  }
}
