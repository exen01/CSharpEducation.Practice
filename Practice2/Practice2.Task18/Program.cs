namespace Practice2.Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, -2, 3, -4, 5, -6, 7 };
            int removed;

            int[] modifiedArray = RemoveNegatives(numbers, out removed);

            Console.WriteLine("array:");
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine("modifyed array:");
            Console.WriteLine(string.Join(", ", modifiedArray));

            Console.WriteLine($"removed number: {removed}");
        }

        static int[] RemoveNegatives(int[] inputArray, out int removedCount)
        {
            List<int> result = new List<int>();
            removedCount = 0;

            foreach (int num in inputArray)
            {
                if (num >= 0)
                {
                    result.Add(num);
                }
                else
                {
                    removedCount++;
                }
            }

            return result.ToArray();
        }
    }
}
