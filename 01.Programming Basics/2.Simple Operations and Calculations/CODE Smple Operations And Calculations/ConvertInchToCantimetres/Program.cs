using System;

namespace ConvertInchToCantimetres
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console inches
            double inches = double.Parse(Console.ReadLine());

            //convert inches to cm
            double cantimetres = inches * 2.54;

            //write to console cm
            Console.WriteLine(cantimetres);
        }
    }
}
