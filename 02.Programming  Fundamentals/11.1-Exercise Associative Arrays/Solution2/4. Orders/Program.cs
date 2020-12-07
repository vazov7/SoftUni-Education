using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            List<string> input = Console.ReadLine().Split().ToList();
            while (input[0] != "buy")
            {
                string item = input[0];

                List<double> priceAndQuantity = new List<double> { double.Parse(input[1]), double.Parse(input[2]) };

                if (!products.ContainsKey(item))
                {

                    products.Add(item, priceAndQuantity);
                }
                else
                {

                    products[item][0] = priceAndQuantity[0];
                    products[item][1] += priceAndQuantity[1];

                }


                input = Console.ReadLine().Split().ToList();
            }
            foreach (var key in products)
            {
                double price = products[key.Key][0];
                double quantity = products[key.Key][1];
                double sum = price * quantity; 
                Console.WriteLine($"{key.Key} -> {sum:f2}");
            }
        }
    }
}
