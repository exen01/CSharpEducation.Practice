namespace Practice2.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            int a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("a should not be equal to zero");
                return;
            }

            Console.WriteLine("Enter b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter f:");
            int f = int.Parse(Console.ReadLine());

            var result = (a + b - f / a) + f * a * a - (a + b);
            Console.WriteLine("Result: " + result);
        }
    }
}
