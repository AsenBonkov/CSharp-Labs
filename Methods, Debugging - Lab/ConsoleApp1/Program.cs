namespace BlankReciept
{
    using System;

    class Program
    {
        static void PrintRecieptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void RecieptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void RecieptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
        static void PrintReciept()
        {
            PrintRecieptHeader();
            RecieptBody();
            RecieptFooter();
        }
        static void Main(string[] args)
        {
            PrintReciept();
        }
    }

}
