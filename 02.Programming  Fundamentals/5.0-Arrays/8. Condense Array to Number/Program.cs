using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condense = new int[nums.Length - 1];


            while (nums.Length != 0)
            {

                for (int i = 0; i < nums.Length; i++)
                {
                    condense[i] = nums[i] + nums[i + 1];
                    nums[i] = condense[i];
                }
                nums.Length -= 1; 

                Console.WriteLine(nums[0]);
            }
        }
    }
}
