using System;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read From console three numbers "b1, b2 and h"
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //canculate area from b1 b2 and h ."(b1 + b2) * h / 2."
            double area = (b1 + b2) * h / 2;

            //Write to console area
            Console.WriteLine("{0:F2}", area);
        }
    }
}
