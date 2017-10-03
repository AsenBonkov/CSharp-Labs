using System;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit = int.Parse(Console.ReadLine());
            double celsius = FaranheitToCelsius(fahrenheit);
            Console.WriteLine("{0:F2}", celsius);
        }

        static double FaranheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

    }
}
