using System;

namespace SummerClothes
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string stateOfDay = Console.ReadLine();
            string outfit = string.Empty;
            string shoes = string.Empty;

            switch (stateOfDay)
            {
                case "Morning":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees > 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Evening":

                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

            //if (stateOfDay == "Morning")
            //{
            //    if (degrees >= 10 && degrees <= 18)
            //    {
            //        outfit = "Sweatshirt";
            //        shoes = "Sneakers";
            //    }
            //    else if (degrees > 18 && degrees <= 24)
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else if (degrees > 24)
            //    {
            //        outfit = "T-Shirt";
            //        shoes = "Sandals";
            //    }
            //}
            //else if (stateOfDay == "Afternoon")
            //{
            //    if (degrees >= 10 && degrees <= 18)
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else if (degrees > 18 && degrees <= 24)
            //    {
            //        outfit = "T-Shirt";
            //        shoes = "Sandals";
            //    }
            //    else if (degrees > 24)
            //    {
            //        outfit = "Swim Suit";
            //        shoes = "Barefoot";
            //    }
            //}
            //else if (stateOfDay == "Evening")
            //{
            //    if (degrees >= 10 && degrees <= 18)
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else if (degrees > 18 && degrees <= 24)
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else if (degrees > 24)
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //}


        }
    }
}
