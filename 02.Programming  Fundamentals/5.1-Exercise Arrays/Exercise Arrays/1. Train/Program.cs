using System;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[int.Parse(Console.ReadLine())];
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine().ToArray());
                sum += num[i];
            }

            Console.WriteLine(string.Join(' ', num));
            Console.WriteLine(sum);
        }
    }
}
