using System;

namespace _11_Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            if(num <= 10)
            {
                for (int i = count; i <= 10; i++)
                {
                    int sum = num * i;
                    Console.WriteLine($"{num} X {i} = {sum}");
                }
            }
            else
            {
                Console.WriteLine($"{num} X {count} = {num * count}");
            }
        }
    }
}
