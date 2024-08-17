using Practice5.Task2;

namespace Practice5.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      ConsoleLogger consoleLogger = new();
      FileLogger fileLogger = new();

      Employee employee = new("E1", 100);
      consoleLogger.Log("Create employee", LogLevel.Info);
      fileLogger.Info("Create employee");

      Manager manager = new("M1", 100, 6);
      consoleLogger.Log("Create manager", LogLevel.Info);
      fileLogger.Info("Create manager");

      Contractor contractor = new("C1", 300, 2);
      consoleLogger.Log("Create contractor", LogLevel.Info);
      fileLogger.Info("Create contractor");

      PrintBonus(employee);
      consoleLogger.Log("print employee bonus", LogLevel.Info);
      fileLogger.Info("print employee bonus");

      PrintBonus(manager);
      consoleLogger.Log("print manager bonus", LogLevel.Info);
      fileLogger.Info("print manager bonus");

      PrintBonus(contractor);
      consoleLogger.Log("print contractor bonus", LogLevel.Info);
      fileLogger.Info("print contractor bonus");
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
