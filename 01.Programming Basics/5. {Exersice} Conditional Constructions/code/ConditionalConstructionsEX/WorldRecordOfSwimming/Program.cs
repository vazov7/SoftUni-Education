using System;

namespace WorldRecordOfSwimming
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console sec to beat , metres , sec per meter
            double secToBeat = double.Parse(Console.ReadLine());
            double metres = double.Parse(Console.ReadLine());
            double secPer1Metre = double.Parse(Console.ReadLine());

            double hisTimeInSec = metres * secPer1Metre;
            //to every 15 metres is add 12.5sec
            double timeSlowerFirstPart = Math.Floor(Math.Abs(metres / 15));
            double timeSlower = timeSlowerFirstPart * 12.5;
            //calculate total time 
            double totalTime = hisTimeInSec + timeSlower;

            // if totalTime < secToBeat ><> " Yes, he succeeded! The new world record is {времето на Иван} seconds." F2
            if (totalTime < secToBeat)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                double lackingSec = totalTime - secToBeat;
                Console.WriteLine($"No, he failed! He was {lackingSec:F2} seconds slower.");
            }
            // if totalTime > secToBeat ><> "No, he failed! He was {недостигащите секунди} seconds slower." <> totalTime - secToBeat

        }
    }
}
