using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.__2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int inputRow = matrixSize[0];
            int intputCol = matrixSize[1];

            int[,] matrix = new int[inputRow,intputCol];

            for (int row = 0; row < inputRow; row++)
            {
                List<char> input = Console.ReadLine().Split().Select(char.Parse).ToList(); 
                for (int col = 0; col < intputCol; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int count = 0;
            for (int row = 0; row < inputRow-1; row++)
            {
                for (int col = 0; col < intputCol-1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row + 1, col] == matrix[row, col] && matrix[row, col + 1] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }


                }
            }
           
            
                Console.WriteLine(count);
            
        }
    }
}
