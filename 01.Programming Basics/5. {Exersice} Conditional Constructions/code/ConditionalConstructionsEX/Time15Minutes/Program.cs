using System;

namespace Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //read hour and minutes
            int startHours = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());
            //convert hours and minutes to minutes + 15
            int totalMinutes = startHours * 60 + startMinutes + 15;
            //convert total minutes to hours and minutes
            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;
            //make conditional if hours = 24 ><> 24 to 00            
            if (hours == 24)
            {
                hours = 0;
            }
            if (minutes < 10)
            {

                
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
