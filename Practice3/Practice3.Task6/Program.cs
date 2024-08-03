namespace Practice3.Task6
{
    internal class Program
    {
        struct Point
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Point p1 = new Point() { y = 1, x = 1 };
            Point p2 = new Point() { x = 5, y = 5 };
            Console.WriteLine(CalculatePointDistance(p1, p2));
        }

        static double CalculatePointDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }
    }
}
