using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            List<double> secondList = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> result = new List<double>();
            if (firstList.Count < secondList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }
                for (int i = firstList.Count; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }
            else if (secondList.Count < firstList.Count)
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }
                for (int i = secondList.Count; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    
    }
}
