using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionButique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            int sum = 0;
            int neededRacks = 1;
            foreach (var item in input)
            {
                stack.Push(item);
            }
            
            while (stack.Count > 0)
            {
                sum += stack.Peek();
                if (sum == rackCapacity && stack.Count >0)
                {
                    neededRacks++;
                    sum = 0;
                }
                else if (sum > rackCapacity)
                {
                    //ако суматата остава по голяма от мястото на рака може да гръмне
                    neededRacks++;
                    sum = 0;
                }
                else if (stack.Count == 1 && sum < rackCapacity)
                {
                    neededRacks++;
                }
                stack.Pop();
            }
            Console.WriteLine(neededRacks);

        }
    }
}
