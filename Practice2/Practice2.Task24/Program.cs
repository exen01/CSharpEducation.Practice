namespace Practice2.Task24
{
    internal class Program
    {
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Дни недели:");

            foreach (string day in Enum.GetNames(typeof(DaysOfWeek)))
            {
                Console.WriteLine(day);
            }
        }
    }
}
