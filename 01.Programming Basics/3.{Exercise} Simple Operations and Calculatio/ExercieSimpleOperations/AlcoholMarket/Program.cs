using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            // 50=wiskeyPrice; 10=beer liters; 3.5=wine liters; 6.5=rakia liters; 1=whiskey liters
            //read from console the price of the whiskey in lv/liter (50lv= 1liter)
            double wihskeyPrice = double.Parse(Console.ReadLine());
            //read from console the quantity of beer, wine, rakia and whiskey in litre
            double beerLiter = double.Parse(Console.ReadLine());
            double wineLiter = double.Parse(Console.ReadLine());
            double rakiaLiter = double.Parse(Console.ReadLine());
            double whiskeyLiter = double.Parse(Console.ReadLine());
            //calculate liter-Price of liter of (Beer) (Wine) (Rakia) (Whiskey) with % Formula { 40% of 100% = {60% * 0,001 = 0.6} = 0.6 * rakiaPrice}
            double rakiaPrice = wihskeyPrice / 2;
            double winePrice = 0.6 * rakiaPrice; //40%of rakiaPrice=60%<>0.6 * rakiaPrice
            double beerPrice = 0.2 * rakiaPrice; //80% of rakiaPrice=20%<>0.2 *rakiaPrice
            //calculate amouth of (Beer) (Wine) (Rakia) (Whiskey) = Price {price * liters}
            double literPriceRakia = rakiaLiter * rakiaPrice;//rakiaPrice * rakiaLiter;
            double literPriceWine = wineLiter * winePrice;//winePrice * wineLiter;
            double lierPriceBeer = beerLiter * beerPrice;//beerPrice * beerLiter;
            double literPriceWhiskey = whiskeyLiter * wihskeyPrice;//wiskeyPrice * wineLiter;
            //calcualte total price of (Beer) (Wine) (Rakia) (Whiskey)
            double totalPrice = literPriceRakia + literPriceWine + lierPriceBeer + literPriceWhiskey;
            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
