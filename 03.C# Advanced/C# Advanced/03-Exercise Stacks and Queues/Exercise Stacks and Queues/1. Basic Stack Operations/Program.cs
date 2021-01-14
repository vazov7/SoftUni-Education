using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = input[0];
            int s = input[1];
            int x = input[2];
            Stack<int> numbers = new Stack<int>();
            List<string> numbersInput = Console.ReadLine().Split().ToList();

            for (int i = 0; i < n; i++)
                numbers.Push(int.Parse(numbersInput[i]));

            for (int i = 0; i < s; i++)
                numbers.Pop();

            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (!numbers.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }

        }
    }
}
