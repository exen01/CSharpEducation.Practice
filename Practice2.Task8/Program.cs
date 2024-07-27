namespace Practice2.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == b || a == c || b == c)
            {
                Console.WriteLine($"{a * 5} {b * 5} {c * 5}");
            }
            else
            {
                Console.WriteLine("равных нет");
            }
        }
    }
}
