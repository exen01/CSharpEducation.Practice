namespace Practice5.Task2
{
  public class ConsoleLogger : ILogger
  {
    public void Log(string message)
    {
      Console.WriteLine(message);
    }

    public void Log(string message, LogLevel logLevel)
    {
      DateTime dateTime = DateTime.Now;
      Console.WriteLine($"{dateTime} | {nameof(ConsoleLogger)} | {logLevel} | {message}");
    }

    public void Trace(string message)
    {
      DateTime dateTime = DateTime.Now;
      Console.WriteLine($"{dateTime} | {nameof(ConsoleLogger)} | {LogLevel.Trace} | {message}");
    }

    public void Info(string message)
    {
      DateTime dateTime = DateTime.Now;
      Console.WriteLine($"{dateTime} | {nameof(ConsoleLogger)} | {LogLevel.Info} | {message}");
    }

    public void Debug(string message)
    {
      DateTime dateTime = DateTime.Now;
      Console.WriteLine($"{dateTime} | {nameof(ConsoleLogger)} | {LogLevel.Debug} | {message}");
    }

    public void Warning(string message)
    {
      DateTime dateTime = DateTime.Now;
      Console.WriteLine($"{dateTime} | {nameof(ConsoleLogger)} | {LogLevel.Warning} | {message}");
    }

    public void Error(string message)
    {
      DateTime dateTime = DateTime.Now;
      Console.WriteLine($"{dateTime} | {nameof(ConsoleLogger)} | {LogLevel.Error} | {message}");
    }

    public void Fatal(string message)
    {
      DateTime dateTime = DateTime.Now;
      Console.WriteLine($"{dateTime} | {nameof(ConsoleLogger)} | {LogLevel.Fatal} | {message}");
    }
  }
}
