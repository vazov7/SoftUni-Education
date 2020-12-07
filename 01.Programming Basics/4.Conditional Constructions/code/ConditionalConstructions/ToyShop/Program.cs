using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Price of toys: Puzzle = 2.60lv; speakDoll = 3lv; TedyBear = 4.10lv; minion = 8.20lv; truck = 2lv;
            //read from console: excursionPrice
            //puzlesNumber
            //speekingDolls
            //bearsNumber
            //minionsNumber     
            //trucksNumber
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzleNumber = int.Parse(Console.ReadLine());
            int speekingDollsNumber = int.Parse(Console.ReadLine());
            int teddyBearNumber = int.Parse(Console.ReadLine());
            int minionsNumber = int.Parse(Console.ReadLine());
            int trucksNumber = int.Parse(Console.ReadLine());
            //calculate total price
            double amounthOfNumberToys = (puzzleNumber * 2.60) + (speekingDollsNumber * 3) + (teddyBearNumber * 4.10) + (minionsNumber * 8.20) + (trucksNumber * 2);
            int numberOfToys = puzzleNumber + speekingDollsNumber + teddyBearNumber + minionsNumber + trucksNumber;
            double priceWithRent = amounthOfNumberToys * 0.90;
            //calculate totalNumber of toys and convert >= 50 with 25% off.
            //if toysNumber >= 50 - the shop makes a 25% discount on the total price
            if (numberOfToys >= 50)
            {
                double twentyFiveProcentOff = priceWithRent * 0.75;


                if (twentyFiveProcentOff >= excursionPrice)
                {
                    double finalPriceYes = twentyFiveProcentOff - excursionPrice;
                    //Console.WriteLine(finalPriceYes);
                    Console.WriteLine($"Yes! {finalPriceYes:F2} lv left.");
                }
            }
            else
            {
                double notEnoughtMoney = excursionPrice - priceWithRent;
                Console.WriteLine($"Not enough money! {notEnoughtMoney:F2} lv needed.");
            }

            //calculate -10% of totalPrice need to rent to shop.
            //calculate totalPrice with 25% discount
            //If the money is enough for excursion, print	"Yes! {оставащите пари} lv left."
            //if the money didnt enought, print  "Not enough money! {недостигащите пари} lv needed."
        }
    }
}
