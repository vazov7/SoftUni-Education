using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int rows = input[0];
            int cols = input[1];
            int sum = 0;
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                List<int> rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }

            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
