namespace Practice2.Task1
{
    internal class Program
    {
        static void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void WhileLoop()
        {
            int whileCounter = 10;
            while (whileCounter >= 0)
            {
                Console.WriteLine(whileCounter);
                whileCounter--;
            }
        }

        static void DoWhileLoop()
        {
            int whileCounter = 10;
            do
            {
                Console.WriteLine(whileCounter);
                whileCounter--;

            } while (whileCounter >= 0);
        }

        static void PhrasesForLoop()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Enter any word: ");
                string word = Console.ReadLine();
                Console.WriteLine("You just enter " + word);
            }
        }

        static void PhrasesWhileLoop()
        {
            int whileCounter = 10;
            while (whileCounter >= 0)
            {
                Console.WriteLine("Enter any word: ");
                string word = Console.ReadLine();
                Console.WriteLine("You just enter " + word);
                whileCounter--;
            }
        }

        static void PhrasesDoWhileLoop()
        {
            int whileCounter = 10;
            do
            {
                Console.WriteLine("Enter any word: ");
                string word = Console.ReadLine();
                Console.WriteLine("You just enter " + word);
                whileCounter--;

            } while (whileCounter >= 0);
        }

        static void Main(string[] args)
        {
            ForLoop();
            WhileLoop();
            DoWhileLoop();
            PhrasesForLoop();
            PhrasesWhileLoop();
            PhrasesDoWhileLoop();
        }
    }
}
