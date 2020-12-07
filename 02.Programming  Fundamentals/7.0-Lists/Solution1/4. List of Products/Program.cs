using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace _4._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
                products.Sort();
            }
            for (int i = 0; i < n; i++)
            {
               
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
