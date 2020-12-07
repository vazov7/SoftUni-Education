using System;

namespace Problem_1._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalEnergy = int.Parse(Console.ReadLine());
            bool isOverEnergy = false;
            string command;
            int winCount = 0;
            int count = 0;
            while ((command = Console.ReadLine())?.ToLower() != "end of battle")
            {

                int distance = int.Parse(command);
                if (totalEnergy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {totalEnergy} energy");
                    isOverEnergy = true;
                    break;
                }
                else
                {
                    winCount++;
                    count++;
                    totalEnergy -= distance;
                }
                if (winCount >= 3)
                {
                    totalEnergy += count;

                    winCount = 0;
                }
            }
            if (!isOverEnergy)
            {
                Console.WriteLine($"Won battles: {count}. Energy left: {totalEnergy}");
            }

        }
    }
}
