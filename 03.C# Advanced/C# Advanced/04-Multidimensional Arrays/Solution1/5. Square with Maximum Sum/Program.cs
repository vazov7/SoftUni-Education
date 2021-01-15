using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
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
                List<int> rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];

                }
            }
            int squareMaxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int squareSum = matrix[row, col] + matrix[row, col + 1] + matrix[row+1 , col] + matrix[row + 1, col + 1];
                    if (squareSum > squareMaxSum)
                    {
                        squareMaxSum = squareSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }
            for (int row = maxSumRow; row <= maxSumRow+1 ; row++)
            {
                for (int col = maxSumCol; col <= maxSumCol+1; col++)
                {
                    Console.Write(matrix[row,col]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(squareMaxSum);


        }
    }
}
