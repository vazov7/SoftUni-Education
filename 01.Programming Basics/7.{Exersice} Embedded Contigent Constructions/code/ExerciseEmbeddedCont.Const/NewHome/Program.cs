using System;

namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int flowersNum = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            //Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            double price = 0.0;
            switch (typeFlowers)
            {
                case "Roses":
                    price = 5.0;
                    if (flowersNum >= 80)
                    {
                        price = price * 0.90;
                    }
                    break;
                case "Dahlias":
                    price = 3.80;
                    if (flowersNum >= 90)
                    {
                        price = price * 0.85;
                    }
                    break;
                case "Tulips":
                    price = 2.80;
                    if (flowersNum >= 80)
                    {
                        price = price * 0.85;
                    }
                    break;
                case "Narcissus":
                    price = 3.0;
                    if (flowersNum < 120)
                    {
                        price = (price * 0.15) + price;
                    }
                    break;
                case "Gladiolus":
                    price = 2.50;
                    if (flowersNum < 80)
                    {
                        price = (price * 0.20) + price;
                    }
                    break;
            }
            double leftMoney = 0.0;
            double totalPrice = price * flowersNum;

            if (totalPrice <= budget)
            {
                leftMoney = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowersNum} {typeFlowers} and {leftMoney:F2} leva left.");
            }
            else
            {
                double needMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
            }
        }
    }
}
