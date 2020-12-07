using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string enter = Console.ReadLine();
           
            double totalSum = 0;
            while (enter != "Start")
            {
                
                double inMoney = double.Parse(enter);

                if (inMoney == 0.1 || inMoney == 0.2 || inMoney == 0.5 || inMoney == 1 || inMoney == 2)
                {
                    totalSum += inMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inMoney}");
                }
                enter = Console.ReadLine();
            }
            string product = Console.ReadLine().ToLower();
            while (product!= "end")
            {
                if (product == "nuts")
                {
                    totalSum -= 2.0;
                    if (totalSum < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalSum += 2.0;
                    }
                    else
                    {
                        Console.WriteLine("Purchased nuts");
                    }
                }
                else if (product == "water")
                {
                    totalSum -= 0.7;
                    if (totalSum < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalSum += 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Purchased water");
                    }
                }
                else if (product == "crisps")
                {
                    totalSum -= 1.5;
                    if (totalSum < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalSum += 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Purchased crisps");
                    }
                }
                else if (product == "soda")
                {
                    totalSum -= 0.8;
                    if (totalSum < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalSum += 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Purchased soda");
                    }
                }
                else if (product == "coke")
                {
                    totalSum -= 1.0;
                    if (totalSum < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalSum += 1.0;
                    }
                    else
                    {
                        Console.WriteLine("Purchased coke");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Change: {totalSum:F2}");
        }
    }
}
