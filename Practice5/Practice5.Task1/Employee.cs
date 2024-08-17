namespace Practice5.Task1
{
  internal class Employee
  {
    public string Name { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int salary)
    {
      Name = name;
      Salary = salary;
    }

    public virtual double CalculateBonus()
    {
      return (Salary / 100) * 10;
    }
  }
}
