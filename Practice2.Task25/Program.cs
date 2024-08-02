namespace Practice2.Task25
{
    internal class Program
    {
        enum DaysOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер деня недели:");
            int dayNumber = int.Parse(Console.ReadLine());

            DaysOfWeek day = (DaysOfWeek)dayNumber;
            Console.WriteLine($"День недели: {day}");
        }
    }
}
