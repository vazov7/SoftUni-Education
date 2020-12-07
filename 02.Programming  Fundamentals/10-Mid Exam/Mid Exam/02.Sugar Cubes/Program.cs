using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _02.Sugar_Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()?
                               .Split()
                               .Select(int.Parse)
                               .ToList();

            List<string> commands = Console.ReadLine()?.Split().ToList();
            while (commands[0] != "Mort")
            {
                int value = int.Parse(commands[1]);
                if (commands[0] == "Add")
                {
                    numbers.Add(value);
                }
                else if (commands[0] == "Remove")
                {
                    numbers.Remove(value);
                }
                else if (commands[0] == "Replace")
                {
                    int secondNumber = int.Parse(commands[2]);
                    int index = numbers.FindIndex(x => x == value);
                    numbers[index] = secondNumber;
                }
                else if (commands[0] == "Collapse")
                {
                    numbers.RemoveAll(x => x < value);
                }


                commands = Console.ReadLine()?.Split().ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
