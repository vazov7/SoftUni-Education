using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int[] inputArr = n.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> evenNums = new Queue<int>();
            foreach (var item in inputArr)
            {
                if (item % 2 == 0)
                {
                    evenNums.Enqueue(item);
                }
            }
            StringBuilder output = new StringBuilder();
            output.Append(evenNums.Dequeue());

            foreach (var car in evenNums)
            {
                output.Append($", {car}");

            }
            Console.WriteLine(output.ToString());
        }
    }
}
