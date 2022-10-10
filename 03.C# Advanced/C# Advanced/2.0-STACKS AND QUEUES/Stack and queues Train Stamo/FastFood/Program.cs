using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalFoodQuantity = int.Parse(Console.ReadLine());

            List<int> foodList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int biggestOrder = 0;
            Queue<int> queue = new Queue<int>();
            foreach (var item in foodList)
            {
                queue.Enqueue(item);
                if (item > biggestOrder)
                    biggestOrder = item;
            }
            while (queue.Count > 0 )
            {
                if (queue.Peek() > totalFoodQuantity)
                    break;

                totalFoodQuantity -= queue.Peek();
                queue.Dequeue();
            }
            Console.WriteLine(biggestOrder);
            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ",queue.Reverse())}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
