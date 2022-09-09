using System;

namespace _1.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employer1 = int.Parse(Console.ReadLine());
            int employer2 = int.Parse(Console.ReadLine());
            int employer3 = int.Parse(Console.ReadLine());

            int totalStudents = int.Parse(Console.ReadLine());

            int timeOfAllEmployers = employer1 + employer2 + employer3;

            int hoursWork = 0;
            int hoursCount = 0;

            while (totalStudents > 0)
            {
                totalStudents -= timeOfAllEmployers;
                hoursWork++;
                hoursCount++;

                if (hoursCount == 3)
                {
                    hoursWork++;
                    hoursCount = 0;
                }
            }
            Console.WriteLine($"Time needed: {hoursWork}h.");


        }
    }
}
