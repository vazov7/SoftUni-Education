using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = Math.Abs(int.Parse(Console.ReadLine()));
            int lenght = nums.ToString().Length;
            int[] numbers = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                numbers[i] = nums % 10;
                nums /= 10;
            }
            int evenSum = FindEvenSum(numbers);
            int oddSum = FindOddSum(numbers);
            Console.WriteLine(evenSum * oddSum);
        }
        static int FindOddSum(int[] numbers)
        {
            int oddSum = 0;
            int[] oddNums = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    oddNums[i] = numbers[i];
                }

            }
            for (int i = 0; i < oddNums.Length; i++)
            {
                oddSum += oddNums[i];
            }
            return oddSum;

        }
        static int FindEvenSum(int[] numbers)
        {
            int evenSum = 0;
            int[] evenNums = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNums[i] = numbers[i];
                }

            }
            for (int i = 0; i < evenNums.Length; i++)
            {
                evenSum += evenNums[i];
            }
            return evenSum;
        }
    }
}
//Judge 100%
