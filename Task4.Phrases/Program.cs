namespace Task4.Phrases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your first phrase:");
            string firstPhrase = Console.ReadLine();
            Console.WriteLine("Please, enter your second phrase:");
            string secondPhrase = Console.ReadLine();

            Console.WriteLine("Your first phrase is " + firstPhrase +
                " Your second phrase is " + secondPhrase);
        }
    }
}
