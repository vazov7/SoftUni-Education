using System;

namespace _7_Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
            {
                if (day == "Weekday")
                {
                    price = 12;
                }
                else if (day == "Weekend")
                {
                    price = 15;
                }
                else if (day == "Holiday")
                {
                    if ((age >= 0 && age <= 18) == true)
                    {
                        price = 5;
                    }
                    else
                    {
                        price = 10;
                    }
                }
                Console.WriteLine($"{price}$");
            }
            else if (age > 18 && age <= 64)
            {
                if (day == "Weekday")
                {
                    price = 18;
                }
                else if (day == "Weekend")
                {
                    price = 20;
                }
                else if (day == "Holiday")
                {
                    price = 12;

                }
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");

            }

        }
    }
}
