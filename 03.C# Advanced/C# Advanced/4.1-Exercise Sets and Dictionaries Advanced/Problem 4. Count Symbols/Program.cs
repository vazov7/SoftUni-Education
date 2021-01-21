using System;
using System.Collections.Generic;

namespace Problem_4._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> counter = new SortedDictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (counter.ContainsKey(input[i]))
                {
                    counter[input[i]]++;
                }
                else
                {
                    counter.Add(input[i], 1);
                }
            }

            foreach (var symbol in counter)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }

        }
    }
}
