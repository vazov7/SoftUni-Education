using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([a-zA-Z]+)<<(\d+\.?\d*)!(\d+)";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            double totalPrice = 0;
            Console.WriteLine("Bought furniture:");
           
            
            while (input != "Purchase")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    double price = double.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[3].Value);
                    
                    Console.WriteLine(name);
                    totalPrice += price * quantity;
                }

                input = Console.ReadLine(); 
            }
         
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
