namespace Practice2.Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            InvertArray(ints);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }

        private static void InvertArray(int[] array)
        {
            Array.Reverse(array);
        }
    }
}
