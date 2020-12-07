using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seasonType = Console.ReadLine().ToLower();

            string destiantion = string.Empty;
            double spendAmount = 0.0;

            if (budget <= 100)
            {
                destiantion = "Bulgaria";
                    if (seasonType == "summer")
                {
                    spendAmount = budget * 0.3;
                }
                    else if (seasonType == "winter")
                {
                    spendAmount = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destiantion = "Balkans";
                    if (seasonType == "summer")
                {
                    spendAmount = budget * 0.4;
                }
                else if (seasonType == "winter")
                {
                    spendAmount = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destiantion = "Europe";
                spendAmount = budget * 0.9;
            }

            string holidayType = string.Empty;

            switch (seasonType)
            {
                case "summer":
                    holidayType = "Camp";
                    if (destiantion == "Europe")
                        holidayType = "Hotel";
                    break;
                case "winter":
                    holidayType = "Hotel";
                    break;
            }
                    
            Console.WriteLine($"Somewhere in {destiantion}" );
            Console.WriteLine($"{holidayType} - {spendAmount:F2}");

        }
    }
}
