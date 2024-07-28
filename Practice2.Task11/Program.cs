namespace Practice2.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(args[0]);
            int number = int.Parse(args[1]);

            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number;
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
