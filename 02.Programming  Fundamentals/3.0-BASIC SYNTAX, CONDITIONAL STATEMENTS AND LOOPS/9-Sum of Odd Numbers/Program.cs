using System;

namespace _9_Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = 0;
            int count = 0;
            int sum = 0;
            while (count != num)
            {
                if(num1 % 2 == 1)
                {
                    count++;
                    sum += num1;
                    Console.WriteLine(num1);
                    num1++;
                    
                }
                else
                {
                    num1++;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
