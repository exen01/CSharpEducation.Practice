namespace Practice3.Task7
{
    internal class Program
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            Console.WriteLine("В январе " + NumberOfDays(Months.January) + " дней");
        }

        static int NumberOfDays(Months month)
        {
            return month switch
            {
                Months.January => 31,
                Months.February => 28,
                Months.March => 31,
                Months.April => 30,
                Months.May => 31,
                Months.June => 30,
                Months.July => 31,
                Months.August => 31,
                Months.September => 30,
                Months.October => 31,
                Months.November => 30,
                Months.December => 31,
                _ => 0,
            };
        }
    }
}
