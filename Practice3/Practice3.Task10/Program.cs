namespace Practice3.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW");
            PrintCar(car);
        }

        static void PrintCar(Car car)
        {
            Console.WriteLine("Машина марки " + car.Brand);
        }
    }
}
