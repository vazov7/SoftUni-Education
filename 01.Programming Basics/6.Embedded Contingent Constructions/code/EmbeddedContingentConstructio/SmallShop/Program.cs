using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console Town Item Name And quantity
            string item = Console.ReadLine();
            string town = Console.ReadLine();
            double quanntity = double.Parse(Console.ReadLine());
            double price = 0.0;

            switch (town)
            {
                case "Sofia":
                    if (item == "coffee")
                    {
                        price = quanntity * 0.50;
                        Console.WriteLine(price);
                    }
                    else if (item == "water")
                    {
                        price = quanntity * 0.80;
                        Console.WriteLine(price);
                    }
                    else if (item == "beer")
                    {
                        price = quanntity * 1.20;
                        Console.WriteLine(price);
                    }
                    else if (item == "sweets")
                    {
                        price = quanntity * 1.45;
                        Console.WriteLine(price);
                    }
                    else if (item == "peanuts")
                    {
                        price = quanntity * 1.60;
                        Console.WriteLine(price);
                    }
                    break;
                case "Plovdiv":
                    if (item == "coffee")
                    {
                        price = quanntity * 0.40;
                        Console.WriteLine(price);
                    }
                    else if (item == "water")
                    {
                        price = quanntity * 0.70;
                        Console.WriteLine(price);
                    }
                    else if (item == "beer")
                    {
                        price = quanntity * 1.15;
                        Console.WriteLine(price);
                    }
                    else if (item == "sweets")
                    {
                        price = quanntity * 1.30;
                        Console.WriteLine(price);
                    }
                    else if (item == "peanuts")
                    {
                        price = quanntity *1.50;
                        Console.WriteLine(price);
                    }
                    break;
                        case "Varna":
                    if (item == "coffee")
                    {
                        price = quanntity * 0.45;
                        Console.WriteLine(price);
                    }
                    else if (item == "water")
                    {
                        price = quanntity * 0.70;
                        Console.WriteLine(price);
                    }
                    else if (item == "beer")
                    {
                        price = quanntity * 1.10;
                        Console.WriteLine(price);
                    }
                    else if (item == "sweets")
                    {
                        price = quanntity * 1.35;
                        Console.WriteLine(price);
                    }
                    else if (item == "peanuts")
                    {
                        price = quanntity * 1.55;
                        Console.WriteLine(price);
                    }
                    break;
            }
            // sofia plovdiv varna
            //if (town == "Sofia")
            //{
            //    if(item == "coffee")
            //    {
            //        price = quanntity * 0.50;
            //        Console.WriteLine(price);
            //    }
            //    else if (item == "water")
            //    {
            //        price = quanntity * 0.80;
            //        Console.WriteLine(price);
            //    }
            //    else if (item == "beer")
            //    {
            //        price = quanntity * 1.20;
            //        Console.WriteLine(price);
            //    }
            //    else if (item == "sweets")
            //    {
            //        price = quanntity * 1.45;
            //        Console.WriteLine(price);
            //    }
            //    else if (item == "peanuts")
            //    {
            //        price = quanntity * 1.60;
            //        Console.WriteLine(price);
            //    }
            //}
            //else if (town == "Plovdiv")
            //{
            //    if (item == "coffee")
            //    {
            //        price = quanntity * 0.40;
            //        Console.WriteLine(price);
            //    }
            //    else if (item == "water")
            //    {
            //        price = quanntity * 0.70;
            //        Console.WriteLine(price);
            //    }
            //    else if (item == "beer")
            //    {
            //        price = quanntity * 1.15;
            //        Console.WriteLine(price);
            //    }
            //    else if (item == "sweets")
            //    {
            //        price = quanntity * 1.30;
            //        Console.WriteLine(price);
            //    }
            //    else if (item == "peanuts")
            //    {
            //        price = quanntity * 1.50;
            //        Console.WriteLine(price);
            //    }
            //}
            //else if (town == "Varna")
            //{
            //    if (item == "coffee")
            //    {
            //        price = quanntity * 0.45;
            //        Console.WriteLine(price);
            //    }
            //    else if (item == "water")
            //    {
            //        price = quanntity * 0.70;
            //        Console.WriteLine(price);
            //    }
            //    else if (item == "beer")
            //    {
            //        price = quanntity * 1.10;
            //        Console.WriteLine(price);
            //    }
            //    else if (item == "sweets")
            //    {
            //        price = quanntity * 1.35;
            //        Console.WriteLine(price);
            //    }
            //    else if (item == "peanuts")
            //    {
            //        price = quanntity * 1.55;
            //        Console.WriteLine(price);
            //    }
            //}

        }
    }
}
