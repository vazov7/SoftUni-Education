using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonsAndPassagers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPassagers = int.Parse(Console.ReadLine());

            List<string> command = Console.ReadLine().ToLower().Split().ToList();
            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    wagonsAndPassagers.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < wagonsAndPassagers.Count - 1 ; i++)
                    {
                        bool isEnaughtSpace = (wagonsAndPassagers[i] + int.Parse(command[0])) <= maxPassagers;
                        if (isEnaughtSpace)
                        {

                            wagonsAndPassagers[i] += int.Parse(command[0]);
                            break;
                        }

                    }
                }
                command = Console.ReadLine().ToLower().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", wagonsAndPassagers));
        }
    }
}
