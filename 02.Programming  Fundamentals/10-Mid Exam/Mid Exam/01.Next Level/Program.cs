using System;

namespace _01.Next_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            double needExperience = double.Parse(Console.ReadLine());
            int inputCount = int.Parse(Console.ReadLine());
            double totalExperience = 0;
            int count = 0;

            // 500
            // 5
            //


            for (int i = 0; i < inputCount; i++)
            {
                double experience = double.Parse(Console.ReadLine());
                count++;
                if (count == 3)
                {
                    totalExperience += experience + (experience * 0.15);
                }
                else if (count == 5)
                {
                    totalExperience += experience - (experience * 0.10);
                }
                else if (count == 15)
                {
                    totalExperience += experience + (experience * 0.05);
                }
                else
                {
                    totalExperience += experience;
                }
                if (totalExperience >= needExperience)
                {
                    break;
                }
            }
            if (totalExperience>= needExperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");
            }
            else
            {
                double neededExperience = needExperience - totalExperience;
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience:F2} more needed.");
            }
            
        }
    }
}
