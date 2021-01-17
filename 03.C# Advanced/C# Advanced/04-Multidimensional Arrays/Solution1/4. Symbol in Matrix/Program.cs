using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                List<char> rowData = new List<char>();
                for (int i = 0; i < input.Length; i++)
                {
                    rowData.Add(input[i]);
                }
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            char finder = char.Parse(Console.ReadLine());
            bool isFindSymbol = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == finder)
                    {
                        isFindSymbol = true;
                        Console.WriteLine($"({row}, {col})");
                    }
                }
            }
            if (!isFindSymbol)
            {
                Console.WriteLine($"{finder} does not occur in the matrix ");
            }
        }
    }
}