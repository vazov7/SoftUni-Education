using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(input);
            Array.Reverse(input);
            List<int> topNumbers = new List<int>();

            double avrg = input.Average();
            if (input.Count() > 1)
            {
                if (input.Count() < 5)
                {
                    for (int i = 0; i < input.Count(); i++)
                    {

                        if (input[i] > avrg)
                        {
                            topNumbers.Add(input[i]);
                        }
                    }

                }
                else
                {

                    for (int i = 0; i < 5; i++)
                    {

                        if (input[i] > avrg)
                        {
                            topNumbers.Add(input[i]);
                        }
                    }
                }

                Console.WriteLine(String.Join(' ', topNumbers));

            }
            else
            {
                Console.WriteLine("No");
            }



        }
    }
}
