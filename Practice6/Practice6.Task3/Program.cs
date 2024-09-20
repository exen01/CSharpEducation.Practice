using Practice5.Task2;

namespace Practice6.Task3;

class Program
{
  static void Main(string[] args)
  {
    ConsoleLogger logger = new ConsoleLogger();

    int attempts = 0;
    const int maxAttempts = 3;
    int age = 0;

    while (true)
    {
      try
      {
        Console.WriteLine("Введите свой возраст: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out age))
        {
          attempts++;

          if (attempts > maxAttempts)
          {
            throw new TooManyAttemptsException("Превышено количество попыток ввода.");
          }

          throw new ArgumentException("Возраст должен быть числом");
        }

        if (age < 18)
        {
          throw new ArgumentException("Вы несовершеннолетний.");
        }

        Console.WriteLine("Доступ разрешен. Ваш возраст: " + age);
        break;
      }
      catch (ArgumentException e)
      {
        logger.Log(e.Message, LogLevel.Error);
        Console.WriteLine("Попробуйте снова.");
      }
      catch (TooManyAttemptsException e)
      {
        logger.Log(e.Message, LogLevel.Error);
        break;
      }
    }
  }
}