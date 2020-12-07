using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool yesOrNo = false;
            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        yesOrNo = true;
                    }
                    if (numbers[i] < numbers[j])
                    {
                        yesOrNo = false;
                    }
                    if (yesOrNo == false)
                    {
                        yesOrNo = false;
                        break;
                    }
                }
                if (yesOrNo == true)
                {
                    Console.Write(" " + numbers[i]);
                }
                yesOrNo = false;
            }
            Console.Write(" " + numbers[numbers.Length - 1]);
        }
    }
}
