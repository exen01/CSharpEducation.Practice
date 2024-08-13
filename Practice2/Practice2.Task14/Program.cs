namespace Practice2.Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreateEmptyArray(5);
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] CreateEmptyArray(int n)
        {
            return new int[n];
        }
    }
}
