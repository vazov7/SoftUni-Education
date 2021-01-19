using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();
            Dictionary<double, int> numbersCount = new Dictionary<double, int>();
            foreach (var item in input)
            {
                if (!numbersCount.ContainsKey(item))
                {
                    numbersCount.Add(item, 1);
                }
                else
                {
                    numbersCount[item] ++; 
                }
            }
            foreach (var item in numbersCount)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
