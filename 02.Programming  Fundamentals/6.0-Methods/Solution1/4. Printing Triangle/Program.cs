using System;

namespace _4._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            MakingTriangle(num);
        }
        static void MakingTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (int i = num -1 ; i >= 1; i--)
            {
                for (int j = 1;  j  <= i;  j ++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
