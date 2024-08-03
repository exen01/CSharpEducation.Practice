namespace Practice3.Task8
{
    internal class Program
    {
        struct Rectangle
        {
            public double width;
            public double height;
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.width = 10;
            rect.height = 5;
            Console.WriteLine($"Площадь прямоугольника с шириной " +
                $"{rect.width} и выслотой {rect.height} равна " +
                CalculateRectangleArea(rect));
        }

        static double CalculateRectangleArea(Rectangle rect)
        {
            return rect.width * rect.height;
        }
    }
}
