namespace Practice2.Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);
            int userGuess = 0;

            Console.WriteLine("A number from 1 to 100 is guessed. Guess it!");

            while (userGuess != targetNumber)
            {
                Console.Write("Введите ваше предположение: ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess == targetNumber)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }
    }
}
