using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double apartamentPrice = 0.0;
            switch (month)
            {
                case "May":
                case "Octomber":
                    studioPrice = 50;
                    apartamentPrice = 65;
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartamentPrice = 68.70;
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartamentPrice = 77;
                    break;
            }

            double studioTotalPrice = studioPrice * nights;
            double apartamentTotalPrice = apartamentPrice * nights;

            if (month == "May" || month == "October")
            {
                if (nights >= 7 && nights <=14)
                {
                    studioTotalPrice = studioTotalPrice * 0.95;
                }
                else if (nights > 14)
                {
                    studioTotalPrice = studioTotalPrice * 0.70;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    studioTotalPrice = studioTotalPrice * 0.80;
                }
            }
            if (nights > 14)
            {
                apartamentTotalPrice = apartamentTotalPrice * 0.90;
            }
            Console.WriteLine($"Apartment: {apartamentTotalPrice:F2} lv.”");
            Console.WriteLine($"Studio: {studioTotalPrice:F2} lv.");
        }
    }
}
