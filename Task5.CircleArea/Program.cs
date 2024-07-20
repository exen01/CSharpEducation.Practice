namespace Task5.CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI;
            int radius = 10;

            Console.WriteLine("Area of the circle is " + (pi * Math.Pow(radius, 2)));
        }
    }
}
