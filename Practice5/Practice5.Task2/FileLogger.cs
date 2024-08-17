using System;

namespace Practice5.Task2
{
  public class FileLogger : ILogger
  {
    private const string FileName = "log.txt";

    public FileLogger()
    {
      if (!File.Exists(FileName))
      {
        File.Create(FileName).Close();
      }
    }

    public void Log(string message)
    {
      using StreamWriter writer = new(FileName, true);
      writer.WriteLine(message);
    }

    public void Log(string message, LogLevel logLevel)
    {
      using StreamWriter writer = new(FileName, true);
      DateTime dateTime = DateTime.Now;
      writer.WriteLine($"{dateTime} | {nameof(FileLogger)} | {logLevel} | {message}");
    }

    public void Trace(string message)
    {
      using StreamWriter writer = new(FileName, true);
      DateTime dateTime = DateTime.Now;
      writer.WriteLine($"{dateTime} | {nameof(FileLogger)} | {LogLevel.Trace} | {message}");
    }

    public void Info(string message)
    {
      using StreamWriter writer = new(FileName, true);
      DateTime dateTime = DateTime.Now;
      writer.WriteLine($"{dateTime} | {nameof(FileLogger)} | {LogLevel.Info} | {message}");
    }

    public void Debug(string message)
    {
      using StreamWriter writer = new(FileName, true);
      DateTime dateTime = DateTime.Now;
      writer.WriteLine($"{dateTime} | {nameof(FileLogger)} | {LogLevel.Debug} | {message}");
    }

    public void Warning(string message)
    {
      using StreamWriter writer = new(FileName, true);
      DateTime dateTime = DateTime.Now;
      writer.WriteLine($"{dateTime} | {nameof(FileLogger)} | {LogLevel.Warning} | {message}");
    }

    public void Error(string message)
    {
      using StreamWriter writer = new(FileName, true);
      DateTime dateTime = DateTime.Now;
      writer.WriteLine($"{dateTime} | {nameof(FileLogger)} | {LogLevel.Error} | {message}");
    }

    public void Fatal(string message)
    {
      using StreamWriter writer = new(FileName, true);
      DateTime dateTime = DateTime.Now;
      writer.WriteLine($"{dateTime} | {nameof(FileLogger)} | {LogLevel.Fatal} | {message}");
    }
  }
}
