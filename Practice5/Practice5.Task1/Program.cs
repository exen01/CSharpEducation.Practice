namespace Practice5.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Employee employee = new Employee();
      employee.Name = "E1";
      employee.Salary = 100;
      Console.WriteLine("Employee salary: {0} bonus {1}", employee.Salary, employee.CalculateBonus());

      Manager manager = new Manager();
      manager.Name = "M1";
      manager.Salary = 200;
      Console.WriteLine("Manager salary: {0} bonus {1}", manager.Salary, manager.CalculateBonus());
    }
  }
}
