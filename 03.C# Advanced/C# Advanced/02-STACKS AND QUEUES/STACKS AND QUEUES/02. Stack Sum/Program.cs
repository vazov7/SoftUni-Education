using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>(numbers);
            List<string> command = Console.ReadLine().ToLower().Split().ToList();
            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                if (command[0] == "remove")
                {
                    int count = int.Parse(command[1]);
                    if (count <= stack.Count)
                    {

                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower().Split().ToList();
            }
            Console.WriteLine("Sum: " + stack.Sum());
        }
    }
}
