using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int notIdenticalCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr1[i])
                {
                    notIdenticalCount++;

                }
            }
            if (notIdenticalCount > 0)
            {
                if (notIdenticalCount == 1)
                {
                    notIdenticalCount = 0;
                }
                Console.WriteLine($"Arrays are not identical. Found difference at {notIdenticalCount} index");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum = arr[i] + arr1[i];
                }
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
