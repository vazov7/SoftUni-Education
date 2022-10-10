using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            int[] secondLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                  .ToArray(); 
            for (int i = 0; i < firstLine[0]; i++)
            {

                stack.Push(secondLine[i]);
            }
            for (int i = 0; i < firstLine[1]; i++)
                stack.Pop();
            if (stack.Contains(firstLine[2]))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count <= 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
