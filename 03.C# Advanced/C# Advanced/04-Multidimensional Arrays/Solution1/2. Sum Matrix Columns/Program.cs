using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                List<int> rowData = Console.ReadLine().Split().Select(int.Parse).ToList();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];

                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row,col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
