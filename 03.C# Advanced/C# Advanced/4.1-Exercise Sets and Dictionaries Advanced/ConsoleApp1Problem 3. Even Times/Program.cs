using System;
using System.Collections.Generic;

namespace ConsoleApp1Problem_3._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (numbers.ContainsKey(input))
                {
                    numbers[input]++;
                }
                else
                {
                    numbers.Add(input,1);

                }
            }
            foreach (var item in numbers)
            {
                if (item.Value % 2 == 0 && item.Value != 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
