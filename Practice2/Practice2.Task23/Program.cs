namespace Practice2.Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");

            int year = int.Parse(Console.ReadLine());
            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} является високосным годом.");
            }
            else
            {
                Console.WriteLine($"{year} не является високосным годом.");
            }
        }

        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
