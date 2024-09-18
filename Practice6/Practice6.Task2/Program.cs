using Practice5.Task2;

namespace Practice6.Task2;

class Program
{
  static void Main(string[] args)
  {
    ConsoleLogger logger = new ConsoleLogger();
    BankAccount regularAccount = new RegularAccount();
    regularAccount.Deposit(100);

    try
    {
      regularAccount.Withdraw(100);
      regularAccount.Withdraw(500);
    }
    catch (InsufficientBalanceException e)
    {
      logger.Log(e.Message, LogLevel.Error);
    }

    BankAccount savingsAccount = new SavingsAccount();
    savingsAccount.Deposit(1000);

    try
    {
      savingsAccount.Withdraw(100);
      savingsAccount.Withdraw(500);
    }
    catch (WithdrawalLimitExceededException e)
    {
      logger.Log(e.Message, LogLevel.Error);
    }
  }
}