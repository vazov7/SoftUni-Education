using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console height and side
            double height = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());

            //Calculate height and side
            double area = height * side / 2;

            //Write to console height and side
            Console.WriteLine("{0:f2}", area);
        }
    }
}
