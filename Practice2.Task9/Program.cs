namespace Practice2.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = CreateArray(3);
            PrintArray(ints);
        }

        static int[] CreateArray(int size)
        {
            return new int[size];
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
