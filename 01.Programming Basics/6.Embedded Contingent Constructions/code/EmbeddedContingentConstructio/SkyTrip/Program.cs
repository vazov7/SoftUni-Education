using System;

namespace SkyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string grate = Console.ReadLine();

            double sleepDays = days - 1;
            double priceSleeps = 0.0;
            switch (roomType)
            {
                case "room for one person":
                    priceSleeps = sleepDays * 18.00;
                    break;
                case "apartment":
                    priceSleeps = sleepDays * 25.00;
                    break;
                case "president apartment":
                    priceSleeps = sleepDays * 35.00;
                    break;
            }
            
            if (roomType == "apartment")
            {
                if (days >= 0 && days < 10)
                {
                    priceSleeps = priceSleeps * 0.70;                    
                }
                else if (days >= 10 && days < 15)
                {
                    priceSleeps = priceSleeps * 0.65;
                }
                else
                {
                    priceSleeps = priceSleeps * 0.50;
                }

            }
            else if (roomType == "president apartment")
            {
                if (days >= 0 && days < 10)
                {
                    priceSleeps = priceSleeps * 0.90;
                }
                else if (days >= 10 && days < 15)
                {
                    priceSleeps = priceSleeps * 0.85;
                }
                else
                {
                    priceSleeps = priceSleeps * 0.80;
                }
            }
            double gratePrice = 0.0;
            double totalPrice = 0.0;
            if (grate == "positive")
            {
                gratePrice = priceSleeps * 0.25;
                totalPrice = priceSleeps + gratePrice;
            }
            else if (grate == "negative")
            {
                totalPrice = priceSleeps * 0.90;
            }
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
