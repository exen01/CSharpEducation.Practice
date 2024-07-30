namespace Practice2.Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 4];

            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 101);
                }
            }

            Console.WriteLine("Generated array:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Difference:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int min = array[i, 0];
                int max = array[i, 0];

                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }

                Console.WriteLine($"row {i + 1}: {max - min}");
            }
        }
    }
}
