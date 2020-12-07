using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<string> command = command = Console.ReadLine().ToLower().Split().ToList();
            while (command[0] != "end")
            {
            
                switch (command[0])
                {
                    case "add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "remove":
                        numbers.Remove(int.Parse(command[1])); 
                        break;
                    case "removeat":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().ToLower().Split().ToList();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
