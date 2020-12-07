
using System;

namespace ThreeBrother
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console three brothers time to cleaning nd father time to back from fishing
            double firstBrotherWorkHoursTime = double.Parse(Console.ReadLine());
            double secoundBrotherWorkHoursTime = double.Parse(Console.ReadLine());
            double thirdBrotherWorkHoursTime = double.Parse(Console.ReadLine());
            double timeHoursFatherBack = double.Parse(Console.ReadLine());
            //convert toatal time to cleaning from three brothers and each separately + 15% time to rest
            double firstBWork = 1 / firstBrotherWorkHoursTime;
            double secoundBWork = 1 / secoundBrotherWorkHoursTime;
            double thirdBWork = 1 / thirdBrotherWorkHoursTime;
            double timeHours = 1 / (firstBWork + secoundBWork + thirdBWork);
            double totalHoursWithRest = (timeHours * 0.15) + timeHours;
            // write first line ><> Cleaning time: {Времето за чистене }
            Console.WriteLine($"Cleaning time: {totalHoursWithRest:f}");
            //write ssecond line:
            //If the brothers surprised the father><> (time left >= 0): "Yes, there is a surprise - time left -> {остатък} hours." ><> Math.Floor
            double timeLeft = timeHoursFatherBack - totalHoursWithRest; 
            if (timeLeft >= 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(timeLeft)} hours." );
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(Math.Abs(timeLeft))} hours.");


            }
            //if the brothers dodn't suprised the father ><> (time left < 0): "No, there isn'сt a surprise - shortage of time -> {недостиг} hours." ><> Math.cele...
        }
    }
}
