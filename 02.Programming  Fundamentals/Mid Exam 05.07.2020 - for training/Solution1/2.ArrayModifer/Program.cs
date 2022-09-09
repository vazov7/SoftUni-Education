using System;
using System.Linq;

namespace _2.ArrayModifer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);    
                if (cmd[0] == "swap")
                {
                    int c = input[int.Parse(cmd[1])];

                    input[int.Parse(cmd[1])] = input[int.Parse(cmd[2])];
                    input[int.Parse(cmd[2])] = c;

                }
                else if (cmd[0] == "multiply")
                {
                    int sum = input[int.Parse(cmd[1])] * input[int.Parse(cmd[2])];
                    input[int.Parse(cmd[1])] = sum;

                }
                else if (cmd[0] == "decrease")
                {
                    for (int i = 0; i < input.Count(); i++)
                    {
                        input[i]--;
                    }
                }
            }
                Console.WriteLine(String.Join(", ", input));
        }
    }
}
