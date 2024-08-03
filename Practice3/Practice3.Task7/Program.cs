namespace Practice3.Task7
{
  internal class Program
  {
    enum Month
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
      Console.WriteLine("В январе " + NumberOfDays(Month.January) + " дней");
    }

    static int NumberOfDays(Month month)
    {
      return month switch
      {
        Month.January => 31,
        Month.February => 28,
        Month.March => 31,
        Month.April => 30,
        Month.May => 31,
        Month.June => 30,
        Month.July => 31,
        Month.August => 31,
        Month.September => 30,
        Month.October => 31,
        Month.November => 30,
        Month.December => 31,
        _ => 0,
      };
    }
  }
}
