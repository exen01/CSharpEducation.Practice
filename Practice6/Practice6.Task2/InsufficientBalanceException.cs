namespace Practice6.Task2;

public class InsufficientBalanceException : Exception
{
  public InsufficientBalanceException(string message) : base(message)
  {
  }
}