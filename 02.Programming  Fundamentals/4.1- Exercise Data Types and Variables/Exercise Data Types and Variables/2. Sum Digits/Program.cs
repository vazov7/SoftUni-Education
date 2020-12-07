using System;

namespace _2._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num != 0)
            {
                int currentNum = num % 10;
                num /= 10;
                sum += currentNum;
            }
                Console.WriteLine(sum);
        }
    }
}
