using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanNum = int.Parse(Console.ReadLine());
            //"Spring", "Summer", "Autumn", "Winter"
            double price = 0.0;

            if (season == "Spring")
                price = 3000;
            else if (season == "Summer" || season == "Autumn")
                price = 4200;
            else if (season == "Winter")
                price = 2600;

            if (fishermanNum <= 6)            
                price = price * 0.90;            
            else if (fishermanNum <= 11)            
                price = price * 0.85;            
            else if (fishermanNum > 12)            
                price = price * 0.75;            

            if (fishermanNum % 2 == 0 && season != "Autumn")            
                price = price * 0.955;
            

            if (price <= budget)
            {
                double leftMoney = budget - price;
                Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
            }
            else if (price > budget)
            {
                double needMoney = price - budget;
                Console.WriteLine($"Not enough money! You need {needMoney:F2} leva.");
            }
        }
    }
}
