using System;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopAndBottom(n);
            for (int i = 1; i <= n - 2; i++)
            {
                PrintMiddleLine(n);
            }
            PrintTopAndBottom(n);
        }
        static void PrintTopAndBottom(int number)
        {
            Console.WriteLine(new string('-', number * 2));
        }
        static void PrintMiddleLine(int number)
        {
            Console.Write('-');
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}
