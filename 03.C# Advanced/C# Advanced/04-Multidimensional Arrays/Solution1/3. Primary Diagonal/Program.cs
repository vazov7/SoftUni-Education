using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];


            for (int row = 0; row < n; row++)
            {
                List<int> inputRow= Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }
            int count = 0;
            int sum = 0;

            for (int row = 0; row < n; row++)
            {
                sum += matrix[row, count];
                count++;
            }
            Console.WriteLine(sum);


        }
    }
}
