using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int start = input[0];
            int end = input[1];
            string evenOrOdd = Console.ReadLine();

            Func<int, int, List<int>> generateNumbers = (s, e) =>
             {
                 List<int> numbers = new List<int>();

                 for (int i = s; i <= e; i++)
                 {
                     if (evenOrOdd == "even" && i % 2 == 0)
                     {

                         numbers.Add(i);
                     }
                     else if (evenOrOdd == "odd" && i % 2 != 0)
                     {
                         numbers.Add(i);
                     }
                 }
                 return numbers;
             };
            Console.WriteLine(string.Join(" ",generateNumbers(start,end)));

        }
    }
}
