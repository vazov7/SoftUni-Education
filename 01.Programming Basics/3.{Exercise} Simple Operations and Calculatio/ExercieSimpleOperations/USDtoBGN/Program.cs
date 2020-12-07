using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console USD and save as variable
            double usd = double.Parse(Console.ReadLine());
            //Convert USD to BGN F2 with funcion - Math.Round().
            double bgn = Math.Round(usd * 1.79549, 2);
            //Write BGN to console
            Console.WriteLine(bgn);
        }
    }
}
