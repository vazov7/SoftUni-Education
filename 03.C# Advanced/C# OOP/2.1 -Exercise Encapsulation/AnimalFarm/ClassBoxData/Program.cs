using System;

namespace ClassBoxData
{
    public class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            try
            {
                var box = new Box(l, w, h);
                Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {box.CalculateValue():F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
