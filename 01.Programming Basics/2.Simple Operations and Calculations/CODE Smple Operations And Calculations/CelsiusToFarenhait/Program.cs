using System;

namespace CelsiusToFarenhait
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console celsius
            double celsius = double.Parse(Console.ReadLine());
            //Convert clsius to fahrenheit form(℉ =℃ * 1.8000 + 32.00)
            double fahrenheit = celsius * 1.8000 + 32.00;
            //write to console fahrenheit and formulate numbers after F2
            Console.WriteLine($"{fahrenheit:F2}");
        }
    }
}
