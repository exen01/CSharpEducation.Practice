namespace Practice6.Task3;

public class TooManyAttemptsException : Exception
{
  public TooManyAttemptsException(string? message) : base(message)
  {
  }
}