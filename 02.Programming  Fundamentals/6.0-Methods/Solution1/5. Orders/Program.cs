using System;
using System.Runtime.CompilerServices;

namespace _5._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            CalculatePrice(product, quantity);
        }
        static void CalculatePrice(string product, int quantity)
        {
            double pricePerProduct = 0;
            double totalPrice = 0;
            if (product == "coffee")
            {
                pricePerProduct = 1.50;
            }
            else if (product == "coke")
            {
                pricePerProduct = 1.40;
            }
            else if (product == "water")
            {
                pricePerProduct = 1.00;
            }
            else if (product == "snacks")
            {
                pricePerProduct = 2.00;
            }
            totalPrice = pricePerProduct * quantity;
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
