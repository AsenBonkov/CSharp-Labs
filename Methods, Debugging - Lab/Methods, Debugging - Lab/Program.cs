using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(numberOne, numberTwo));
        }

        static double RaiseToPower(double number, double power)
        {
            double result = 0;
            result = Math.Pow(number, power);
            return result;    
        }
    }
}
