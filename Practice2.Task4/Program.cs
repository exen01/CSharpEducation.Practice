namespace Practice2.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter triangle height:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter char for triangle");
            char triangleChar = char.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(triangleChar);
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(' ');
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(triangleChar);
                }
                Console.WriteLine();
            }
        }
    }
}
