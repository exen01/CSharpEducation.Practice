
namespace Practice2.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "hello world";
            char targetChar = 'o';

            double percentage = CalculateCharPercentage(inputString, targetChar);
            Console.WriteLine($"Percentage of occurrence of a character '{targetChar}' in a string: {percentage}%");

            Console.WriteLine("Enter string:");
            inputString = Console.ReadLine();

            Console.WriteLine("Enter char:");
            targetChar = char.Parse(Console.ReadLine());

            percentage = CalculateCharPercentage(inputString, targetChar);
            Console.WriteLine($"Percentage of occurrence of a character '{targetChar}' in a string: {percentage}%");

            inputString = args[0];
            targetChar = args[1][0];

            percentage = CalculateCharPercentage(inputString, targetChar);
            Console.WriteLine($"Percentage of occurrence of a character '{targetChar}' in a string: {percentage}%");
        }

        private static double CalculateCharPercentage(string inputString, char targetChar)
        {
            int count = 0;
            foreach (char c in inputString)
            {
                if (c == targetChar)
                    count++;
            }

            return (double)count / inputString.Length * 100;
        }
    }
}
