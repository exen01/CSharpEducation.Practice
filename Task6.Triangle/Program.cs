namespace Task6.Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstSide = 6; 
            int secondSide = 8;
            double hypotenuse = Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2));

            Console.WriteLine("Task A: " + hypotenuse);

            int firstSideB = 6;
            int hypotenuseB = 10;
            double secondSideB = Math.Sqrt(Math.Pow(hypotenuseB, 2) - Math.Pow(firstSideB,2));
            Console.WriteLine("Task B: " + secondSideB);
        }
    }
}
