namespace Practice2.Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);
            int userGuess = 0;
            int maxAttempts = 10;
            int attempts = 0;

            Console.WriteLine("Загадывается число от 1 до 100. Угадайте!");

            while (attempts < maxAttempts && userGuess != targetNumber)
            {
                Console.Write("Введите ваше предположение: ");
                userGuess = int.Parse(Console.ReadLine());

                attempts++;
                if (userGuess < targetNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else if (userGuess > targetNumber)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else
                {
                    Console.WriteLine($"Вы угадали число {targetNumber} за {attempts} попыток.");
                    return;
                }
            }

            if (userGuess != targetNumber)
            {
                Console.WriteLine($"Вы исчерпали все {maxAttempts} попыток. Вы проиграли. Загаданное число было {targetNumber}.");
            }
        }
    }
}
