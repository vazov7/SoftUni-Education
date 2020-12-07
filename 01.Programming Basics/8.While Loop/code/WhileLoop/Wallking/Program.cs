using System;

namespace Wallking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int stepsTarget = 10000;
            while (true)
            {
                var stringSteps = Console.ReadLine();

                if(stringSteps == "Going home")
                {
                    int leftSteps = int.Parse(Console.ReadLine());
                    steps += leftSteps;
                    if(steps < stepsTarget)
                    {
                        int leffter = stepsTarget - steps;
                        Console.WriteLine($"{leffter} more steps to reach goal.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                }
                steps += int.Parse(stringSteps);
                if(steps >= stepsTarget)
                {
                    int enterSteps = int.Parse(stringSteps);
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }                


            }
        }
    }
}
