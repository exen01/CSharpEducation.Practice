namespace Practice2.Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 15;
            int[] numbers = new int[arrayLength];

            Random random = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                numbers[i] = random.Next(1, 101);
            }

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < arrayLength; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            int difference = max - min;
            Console.WriteLine($"Diff between max ({max}) and min ({min}) is: {difference}");
        }
    }
}
