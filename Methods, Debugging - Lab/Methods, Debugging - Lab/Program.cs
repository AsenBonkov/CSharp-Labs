using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(numberOne, numberTwo));
        }

        static double RaiseToPower(double number, int power)
        {
            double result = 0d;
            result = Math.Pow(number, power);
            return result;    
        }
    }
}
