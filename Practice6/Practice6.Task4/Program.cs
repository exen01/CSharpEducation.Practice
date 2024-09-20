using Practice5.Task2;

namespace Practice6.Task4;

class Program
{
  static void Main(string[] args)
  {
    ConsoleLogger logger = new ConsoleLogger();

    string filePath = "";
    bool fileFound = false;

    while (!fileFound)
    {
      try
      {
        Console.WriteLine("Введите путь к текстовому файлу:");
        filePath = Console.ReadLine();
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine("Данные из файла:\n" + fileContent);
        fileFound = true;
      }
      catch (FileNotFoundException e)
      {
        logger.Log(e.Message, LogLevel.Error);
      }
      catch (IOException e)
      {
        if (e.Message.Contains("it is being used by another process."))
        {
          Console.WriteLine($"Файл заблокирован другим процессом: {e.Message}");
          Console.WriteLine("Повторить попытку через несколько секунд? (да/нет)");
          string choice = Console.ReadLine();

          if (choice.ToLower() == "да")
          {
            try
            {
              Thread.Sleep(2000);
              string fileContent = File.ReadAllText(filePath);
              Console.WriteLine("Данные из файла:\n" + fileContent);
              fileFound = true;
            }
            catch (Exception ex)
            {
              logger.Log(ex.Message, LogLevel.Error);
            }
          }
          else
          {
            Console.WriteLine("Выберите другой файл.");
          }
        }
        else
        {
          Console.WriteLine("Ошибка при чтении файла.");
          logger.Log(e.Message, LogLevel.Error);
          Console.WriteLine("Пожалуйста, исправьте данные в файле или введите корректный путь к файлу.");
        }
      }
      catch (Exception e)
      {
        logger.Log(e.Message, LogLevel.Error);
      }
    }

    Console.ReadKey();
  }
}