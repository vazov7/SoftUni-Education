using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < firstArr.Length; i++)
            {
                int[] inArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i %2 == 0)
                {
                    firstArr[i] += inArr[0];
                    secondArr[i] += inArr[1];
                }
                else
                {

                    firstArr[i] += inArr[1];
                    secondArr[i] += inArr[0];
                        
                }
            }
            Console.WriteLine(string.Join(' ', firstArr));
            Console.WriteLine(string.Join(' ', secondArr));
        }
    }
}
