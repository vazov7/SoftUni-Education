using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console Number of rectangular tables-(Tables)
            //read from console Length of rectangular tables in meters (length)
            //Read from console Width of rectangular tables in meters (width)
            int tables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            //create various of The total area of the covers (coversArea)
            double coversArea = tables * (length + 2 * 0.30) * (width + 2 * 0.30);
            //create various of The total area of the coach (coachArea)
            double coachArea = tables * (length / 2) * (length / 2);
            //calculate total price in USD and BGN 
            double usd = coversArea * 7 + coachArea * 9;
            double bgn = usd * 1.85;
            //Write to console USD and BGN
            Console.WriteLine($"{usd:F2} USD");
            Console.WriteLine($"{bgn:F2} BGN");
        }
    }
}
