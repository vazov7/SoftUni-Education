using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MaximunAndMinumunElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                List<int> input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                if (input[0] == 1)
                {
                    queue.Enqueue(input[1]);
                }
                else if (input[0] == 2)
                {
                    if (queue.Count != 0)
                        queue.Dequeue();

                }
                else if (input[0] == 3)
                {
                    if (queue.Count != 0)
                        Console.WriteLine(queue.Max());
                }
                else if (input[0] == 4)
                {
                    if (queue.Count != 0)
                        Console.WriteLine(queue.Min());
                }

            }
            Console.WriteLine(String.Join(", ", queue.Reverse()));

            //before delete make sure tht is stack count is not 0

        }
    }
}
