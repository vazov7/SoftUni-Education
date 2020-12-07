using System;

namespace Voleyball
{

    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            double holidaysNum = double.Parse(Console.ReadLine());
            double vilageWeekendsNum = double.Parse(Console.ReadLine());

            int weekendsInYear = 48;
            double weekendsInSofia = weekendsInYear - vilageWeekendsNum;
            double playingDaysInSofia = 0.75 * weekendsInSofia;
            double vilagePlayingDays = vilageWeekendsNum;

            double holidayPlayingDays = 0.6666666667 * holidaysNum; ;

            double playingDays = playingDaysInSofia + vilagePlayingDays + holidayPlayingDays;

            double totalYearPlayingDays = 0.0;
            if (typeYear == "leap")
            {
                totalYearPlayingDays = (playingDays * 0.15) + playingDays;
            }
            else if (typeYear == "normal")
            {
                totalYearPlayingDays = playingDays;
            }

            Console.WriteLine(Math.Floor(totalYearPlayingDays));

        }
    }
}
