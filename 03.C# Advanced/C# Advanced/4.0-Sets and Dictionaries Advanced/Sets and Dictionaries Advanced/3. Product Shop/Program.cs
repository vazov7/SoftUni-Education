using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> products = new SortedDictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();
            while (input != "Revision")
            {
                List<string> splitedInput = input.Split(", ").ToList();
                string market = splitedInput[0];
                string product = splitedInput[1];
                double price = double.Parse(splitedInput[2]);
                if (!products.ContainsKey(market))
                {
                    products.Add(market , new Dictionary<string, double>());
                    products[market].Add(product, price);
                }
                else
                {
                    products[market].Add(product, price);
                }
                input = Console.ReadLine();
            }
            foreach (var shop in products)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
