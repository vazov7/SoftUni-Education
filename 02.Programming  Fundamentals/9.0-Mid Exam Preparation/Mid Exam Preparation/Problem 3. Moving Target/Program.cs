using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace Problem_3._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

            while (command[0]?.ToLower() != "end")
            {
                int index = int.Parse(command[1]);
                int value = int.Parse(command[2]);
                bool isIndexExist = IsTargetExist(index, targets);

                if (command[0]?.ToLower() == "shoot" && isIndexExist)
                {
                    targets[index] -= value;
                    if (targets[index]<=0)
                    {
                        targets.RemoveAt(index);
                    }

                }
                else if (command[0]?.ToLower() == "add")
                {
                    if (isIndexExist)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                        
                    }

                }
                else if (command[0]?.ToLower() == "strike")
                {
                    if (index < targets.Count-1 && (index + value) <= targets.Count-1 && (index - value)>=0)
                    {
                        targets.RemoveRange(index - value, index + value);   
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join("|", targets));
        }
        static bool IsTargetExist(int index, List<int> targets)
        {
            //If BROKE REPLACE count-1 == count 
            bool isExitst = index <= targets.Count-1;
            return isExitst;
        }
    }
   
}
