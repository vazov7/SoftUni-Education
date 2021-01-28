using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> minNum = num => num.Min();

            int result = minNum(numbers);
            Console.WriteLine(result);

            //Func<List<int>, int> minNum =
            //    num =>
            //    {
            //        int minNum = int.MaxValue;
            //        foreach (var item in num)
            //        {
            //            if (item < minNum)
            //            {
            //                minNum = item;
            //            }
            //        }
            //        return minNum;
            //    };


        }
    }
}
