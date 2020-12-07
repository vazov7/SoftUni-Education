using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            // read from the console of individual rows its dimensions - length-дължина, width-широчина, height-височина and procent in centimeters.
            double leight = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            //calculate volume from (length * width * height)
            double volume = leight * width * height;

            //calculate in general volume (volume * 0.001)
            double inGeneralLitres = volume * 0.001;

            //calculate procent (procent * 0.01)
            double calculatedProcent = procent * 0.01;

            //Calculate the liters you will actually need.(in general volume *(1- calculatedProcent))
            double litresAcuallyNeed = inGeneralLitres * (1 - calculatedProcent);

            //Write to console the litres you will acually need
            Console.WriteLine($"{litresAcuallyNeed:F3}");

        }
    }
}
