using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] charSeparators = new char[] { ' ' };
            int[] nums = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int leftSum = 0, rightSum = 0;
            int j = 0;
            if (nums.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    leftSum += nums[j];
                }
                for (int k = i + 2; k < nums.Length; k++)
                {
                    rightSum += nums[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(j);
                    return;
                }
                else
                    leftSum = rightSum = 0;
            }
            Console.WriteLine("no");

        }
    }
}