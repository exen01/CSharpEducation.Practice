namespace Practice2.Task2
{
    internal class Program
    {
        static void MetersToKilometers(int meters)
        {
            Console.WriteLine(meters + " meters is " + (meters / 1000) + " kilometers");
        }

        static void KilometersToSantimeters(int kilometers)
        {
            Console.WriteLine(kilometers + " kilometers is " + (kilometers * (100 * 1000)) + " santimeters");
        }

        static void MetersPerSecondToKilometersPerHour(int metersPerSecond)
        {
            Console.WriteLine(metersPerSecond + " meters per second is " + (metersPerSecond * 3.6) + " kilometers per hour");
        }

        static void DegreesCelsiusToDegreesFahrenheit(int degree)
        {
            Console.WriteLine(degree + " Celsius is " + ((degree * 1.8) + 32) + " Fahrenheit");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter meters count:");
            int meters = int.Parse(Console.ReadLine());
            MetersToKilometers(meters);

            Console.WriteLine("Enter kilometers count:");
            int kilometers = int.Parse(Console.ReadLine());
            MetersToKilometers(kilometers);

            Console.WriteLine("Enter meters per second:");
            int metersPerSecond = int.Parse(Console.ReadLine());
            MetersPerSecondToKilometersPerHour(metersPerSecond);

            Console.WriteLine("Enter Celsius Degree:");
            int degreesCelsius = int.Parse(Console.ReadLine());
            MetersPerSecondToKilometersPerHour(degreesCelsius);
        }
    }
}
