using System;

namespace InchToCantimetres
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console inches
            double inches = double.Parse(Console.ReadLine());

            //convert inches to cantimetres(1inch = 2.54 сантиметра)
            double cantimetres = inches * 2.54;

            //write to console cantimetres
            Console.WriteLine($"{cantimetres:F2}");
        }
    }
}
