namespace Practice5.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Employee employee = new Employee("E1", 100);
      //Console.WriteLine("Employee salary: {0} bonus {1}", employee.Salary, employee.CalculateBonus());

      Manager manager = new Manager("M1", 100, 6);
      //Console.WriteLine("Manager salary: {0} bonus {1}", manager.Salary, manager.CalculateBonus());

      Contractor contractor = new Contractor("C1", 300, 2);

      PrintBonus(employee);
      PrintBonus(manager);
      PrintBonus(contractor);
    }

    static void PrintBonus(Employee employee)
    {
      if (employee is Contractor)
      {
        Contractor contractor = (Contractor)employee;
        Console.WriteLine(contractor.CalculateBonus(10));
      }
      else
      {
        Console.WriteLine(employee.CalculateBonus());
      }
    }
  }
}
