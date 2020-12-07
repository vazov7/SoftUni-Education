using System;

namespace DayOfWeekToString
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console Day
            int day = int.Parse(Console.ReadLine());
            //with Swich - case make convwert int number to string{day of week}
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            //days in string is 1-Monday; 2-Tuesday;  3-Wednesday; 4-Thursday; 5-Friday; 6-Saturday; 7-Sunday;
            //if number is biger than 7 write Error
        }
    }
}
