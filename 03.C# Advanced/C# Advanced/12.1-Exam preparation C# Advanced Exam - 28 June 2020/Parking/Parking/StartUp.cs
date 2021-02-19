﻿using System;

namespace Parking
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking("Underground parking garage", 5);
            Car volvo = new Car("Volvo", "XC70", 2010);
            Console.WriteLine(volvo);
            parking.Add(volvo);

            Console.WriteLine(parking.Remove("Volvo", "XC90")); // False
            Console.WriteLine(parking.Remove("Volvo", "XC70"));

            Car peugeot = new Car("Peugeot", "307", 2011);
            Car audi = new Car("Audi", "S4", 2005);

            parking.Add(peugeot);
            parking.Add(audi);


            Car latestCar = parking.GetLatestCar();
            Console.WriteLine(latestCar);


            Car audiS4 = parking.GetCar("Audi", "S4");
            Console.WriteLine(audiS4);

            Console.WriteLine(parking.Count);

            Console.WriteLine(parking.GetStatistics());
        }
    }
}
