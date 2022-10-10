using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOpration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            int[] secondLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                  .ToArray();
            for (int i = 0; i < firstLine[0]; i++)
            {

                queue.Enqueue(secondLine[i]);
            }
            for (int i = 0; i < firstLine[1]; i++)
                queue.Dequeue();
            if (queue.Contains(firstLine[2]))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count <= 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
