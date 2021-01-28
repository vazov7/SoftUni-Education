using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            Func<int, int> aritmethicFunction = num => num;
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ",nums));
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    aritmethicFunction = n => n + 1;
                    numbers = numbers.Select(aritmethicFunction).ToList();
                }
                else if (command == "multiply")
                {
                    aritmethicFunction = n => n * 2;
                    numbers = numbers.Select(aritmethicFunction).ToList();
                }
                else if (command == "subtract")
                {
                    aritmethicFunction = n => n - 1;
                    numbers = numbers.Select(aritmethicFunction).ToList();
                }
                else if(command == "print")
                {
                    print(numbers);
                }
            }

        }
    }
}
