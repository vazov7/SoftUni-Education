using System;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console (x1, y1, x2 and y2 )
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            //calculate sideY and sideX > use variable to save them  (math.Abs())
            double sideX = Math.Abs(x2 - x1);
            double sideY = Math.Abs(y2 - y1);
            //calcuate area and perimeter > 
            double area = sideX * sideY;
            double perimeter = 2 * (sideX + sideY);
            //Write to console area and perimeter
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }

    }
}
