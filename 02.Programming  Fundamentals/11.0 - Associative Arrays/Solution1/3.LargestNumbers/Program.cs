using System;
using System.Linq;

namespace _3.LargestNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read array of int
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)      
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();



            //check if array count < of 3
            if (numbers.Length <= 3 )
            {
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
            else
            {

                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine(numbers[i]);   
                }
            }



        }
    }
}
