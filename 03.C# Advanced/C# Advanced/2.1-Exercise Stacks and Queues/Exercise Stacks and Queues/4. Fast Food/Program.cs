using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            int maxOrder = orders.Max();
            while (true)
            {
                if (totalFood >= orders.Peek())
                {
                    totalFood -= orders.Peek();
                    orders.Dequeue();
                }
                if (orders.Any() && totalFood < orders.Peek())
                {
                    Console.WriteLine(maxOrder);
                    Console.WriteLine("Orders left: " + string.Join(" ", orders));
                    break;
                }
                else if (!orders.Any() && totalFood >= 0)
                {
                    Console.WriteLine(maxOrder);
                    Console.WriteLine("Orders complete");
                    break;
                }

            }
        }
    }
}
