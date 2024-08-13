namespace Practice2.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(args[0]);
            int[] array = new int[size];

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

        }
    }
}
