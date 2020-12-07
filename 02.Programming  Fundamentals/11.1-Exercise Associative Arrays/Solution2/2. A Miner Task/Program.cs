using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, int> resourse = new Dictionary<string, int>();
            while (command != "stop")
            {
                if (resourse.ContainsKey(command))
                {
                    resourse[command] += number;
                }
                else
                {
                    resourse.Add(command, number);
                }

                command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                number = int.Parse(Console.ReadLine());
            }

            foreach (var item in resourse)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }
        }
    }
}
