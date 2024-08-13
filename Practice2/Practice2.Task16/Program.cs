namespace Practice2.Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            ChangeSign(ref number);

            Console.WriteLine(number);
        }

        static void ChangeSign(ref int num)
        {
            num = -num;
        }
    }
}
