using System;
using System.Security.Cryptography;

namespace _3_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peoples = int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();

            double pricePerPerson = 0;
            double totalPrice = 0;

            if (type == "students")
            {
                if (day == "friday")
                {
                    pricePerPerson = 8.45;
                }
                else if (day == "saturday")
                {
                    pricePerPerson = 9.80;
                }
                else if (day == "sunday")
                {
                    pricePerPerson = 10.46;
                }
            }
            else if (type == "business")
            {
                if (day == "friday")
                {
                    pricePerPerson = 10.90;
                }
                else if (day == "saturday")
                {
                    pricePerPerson = 15.60;
                }
                else if (day == "sunday")
                {
                    pricePerPerson = 16;
                }

                if (peoples >= 100)
                {
                    peoples -= 10;
                }
            }
            else if (type == "regular")
            {
                if (day == "friday")
                {
                    pricePerPerson = 15;
                }
                else if (day == "saturday")
                {
                    pricePerPerson = 20;
                }
                else if (day == "sunday")
                {
                    pricePerPerson = 22.50;
                }
            }

            totalPrice = pricePerPerson * peoples;
            if (type == "students" && peoples >= 30)
            {
                
                totalPrice *= 0.85;
            }

            if (type == "regular" && peoples >=10 && peoples <= 20)
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}//83% JUDGE
