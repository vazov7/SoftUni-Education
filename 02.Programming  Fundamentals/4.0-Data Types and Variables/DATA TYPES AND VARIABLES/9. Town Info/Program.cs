using System;

namespace _9._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int square = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {cityName} has population of {population} and area {square} square km.");
        }
    }
}
