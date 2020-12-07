using System;

namespace _2._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());

            decimal dolar = pound * 1.31M;
            Console.WriteLine($"{dolar:f3}");
        }
    }
}
