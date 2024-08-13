namespace Practice2.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int second = int.Parse(Console.ReadLine());

            if (first == second)
            {
                Console.WriteLine(first + " is equal " + second);
            }
            else
            {
                Console.WriteLine(first + " is not equal " + second);
            }
        }
    }
}
