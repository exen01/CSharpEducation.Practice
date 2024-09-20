using Practice5.Task2;

namespace Practice6.Task1;

class Program
{
  static void Main(string[] args)
  {
    ConsoleLogger logger = new ConsoleLogger();

    Console.WriteLine("Укажите имя файла с числами:");
    string fileName = Console.ReadLine();

    while (true)
    {
      try
      {
        using var fileReader = new StreamReader(fileName);
        string? str;

        while ((str = fileReader.ReadLine()) != null)
        {
          string[] digits = str.Split(' ');

          if (digits.Length != 2)
          {
            throw new InvalidDataException("В файле должна быть строка с двумя числами.");
          }

          if (!int.TryParse(digits[0], out int number1) || !int.TryParse(digits[1], out int number2))
          {
            throw new InvalidDataException("В файле должны быть только числа.");
          }

          try
          {
            int result = number1 / number2;
            Console.WriteLine($"Результат деления {number1} на {number2} = {result}");
          }
          catch (DivideByZeroException e)
          {
            logger.Log(e.Message, LogLevel.Error);
          }
        }

        break;
      }
      catch (FileNotFoundException e)
      {
        logger.Log(e.Message, LogLevel.Error);
        Console.WriteLine("Укажите правильный путь к файлу:");
        fileName = Console.ReadLine();
      }
      catch (IOException e)
      {
        logger.Log(e.Message, LogLevel.Error);
        Console.WriteLine("Укажите правильный путь к файлу:");
        fileName = Console.ReadLine();
      }
      catch (InvalidDataException e)
      {
        logger.Log(e.Message, LogLevel.Error);
        Console.WriteLine("Укажите путь к файлу:");
        fileName = Console.ReadLine();
      }
      catch (Exception e)
      {
        logger.Log(e.Message, LogLevel.Error);
        Console.WriteLine("Укажите путь к файлу:");
        fileName = Console.ReadLine();
      }
    }
  }
}