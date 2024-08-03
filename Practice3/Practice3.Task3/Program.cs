namespace Practice3.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("1 + 3 = " + calculator.Addition(1, 3));
            Console.WriteLine("1 - 3 = " + calculator.Subtraction(1, 3));
            Console.WriteLine("1 * 3 = " + calculator.Multiplication(1, 3));
            Console.WriteLine("1 / 3 = " + calculator.Division(1, 3));
        }
    }
}
