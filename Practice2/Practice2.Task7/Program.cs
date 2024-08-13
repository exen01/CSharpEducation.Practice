using System.Globalization;

namespace Practice2.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!".ToUpper());
            Console.WriteLine("Hello, World!".ToLower());
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            Console.WriteLine(ti.ToTitleCase("привет"));
        }
    }
}
