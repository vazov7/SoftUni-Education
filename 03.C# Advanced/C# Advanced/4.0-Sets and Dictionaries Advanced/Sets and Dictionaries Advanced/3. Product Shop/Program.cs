using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> products = new Dictionary<string, Dictionary<string, decimal>>();
            string input = Console.ReadLine();
            while (input != "Revision")
            {
                List<string> splitedInput = input.Split(", ").ToList();
                string market = splitedInput[0];
                string product = splitedInput[0];
                decimal price = decimal.Parse(splitedInput[3]);
                if (!products.ContainsKey(market))
                {
                    products.Add(market , new Dictionary<string, decimal>());
                }

            }




        }
    }
}
