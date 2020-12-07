using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isEvenNum = num % 2 == 0;
            if (isEvenNum)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
