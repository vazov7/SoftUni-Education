using System;

namespace OnTimeForExamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int exampHour = int.Parse(Console.ReadLine());
            int exampMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());           

            int exampTime = (exampHour * 60) + exampMinutes;
            int arrivalTime = (arrivalHour * 60) + arrivalMinutes;
            string lateEarlyOnTime = string.Empty;

            if (arrivalTime < (exampTime - 30))
            {
                lateEarlyOnTime = "Early";
            }
            else if (arrivalTime <= exampTime)
            {
                lateEarlyOnTime = "On Time";
            }
            else if (arrivalTime > exampTime)
            {
                lateEarlyOnTime = "Late";
            }
            Console.WriteLine(lateEarlyOnTime);

            if (lateEarlyOnTime == "On Time" && exampTime != arrivalTime)
            {
                int earlyTime = exampTime - arrivalTime;
                if (earlyTime < 60)
                {
                    Console.WriteLine($"{earlyTime} minutes before the start");
                }
                else
                {
                    int hours = earlyTime / 60;
                    int minutes = earlyTime % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    }
                    else
                    {

                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                }

            }
            else if (lateEarlyOnTime == "Early" && exampTime != arrivalTime)
            {
                int earlyTime = exampTime - arrivalTime;
                if (earlyTime < 60)
                {
                    Console.WriteLine($"{earlyTime} minutes before the start");
                }
                else
                {
                    int hours = earlyTime / 60;
                    int minutes = earlyTime % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    }
                    else
                    {

                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                }

            }
            else if (lateEarlyOnTime == "Late" && exampTime != arrivalTime)
            {
                int earlyTime = arrivalTime - exampTime;
                if (earlyTime < 60)
                {
                    Console.WriteLine($"{earlyTime} minutes after the start");
                }
                else
                {
                    int hours = earlyTime / 60;
                    int minutes = earlyTime % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                    else
                    {

                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                }

            }
        }
    }
}
