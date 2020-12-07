using System;

namespace _4._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            long centuries = long.Parse(Console.ReadLine());

            long years = centuries * 100;
            long days = (long)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
