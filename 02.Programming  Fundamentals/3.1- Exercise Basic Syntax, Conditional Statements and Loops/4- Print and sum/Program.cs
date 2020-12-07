using System;

namespace _4__Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int finishNum = int.Parse(Console.ReadLine());

            int sum = 0;
            
            for (int i = startNum; i <= finishNum; i++)
            {
                Console.Write($" {i}");
                sum += i;
            }
            Console.WriteLine($" ");
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
//100%jUDGE