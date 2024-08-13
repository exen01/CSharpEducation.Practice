namespace Practice2.Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter string:");
                array[i] = Console.ReadLine();
            }

            Console.WriteLine("Your array:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
