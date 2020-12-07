using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Problem_2._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()?.ToLower()) != "end")
            {
                int index = int.Parse(input);
                //check to enter in shot
                if (index <= targets.Count - 1)
                {
                    //if (index != 0)
                    //{
                    //    index = index - 1;
                    //}
                    for (int i = 0; i < targets.Count; i++)
                    {


                        if (targets[index] < targets[i])
                        {
                            targets[i] = targets[i] - targets[index];
                        }
                        else
                        {
                            continue;
                        }
                        if (targets[index] >= targets[i])
                        {
                            targets[i] = targets[i] + targets[index];
                        }   
                    }
                    targets[index] = -1;

                }
            }
            Console.WriteLine(string.Join(" ", targets));
        }
    }
}
