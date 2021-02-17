using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int[] snakePosition = new int[2];
            int[] inputBurrow = new int[2];
            int[] outputBurrow = new int[2];
            int foodQuattity = 0;
            int c = 0;

            for (int col = 0; col < n; col++)
            {
                string inputRow = Console.ReadLine();
                for (int row = 0; row < n; row++)
                {

                    matrix[col, row] = inputRow[row];
                    if (inputRow[row] == 'S')
                    {
                        snakePosition[0] = col;
                        snakePosition[1] = row;
                    }
                    if (inputRow[row] == 'B' && c == 0)
                    {
                        inputBurrow[0] = col;
                        inputBurrow[1] = row;
                        c++;
                    }
                    if (inputRow[row] == 'B' && c == 1)
                    {
                        outputBurrow[0] = col;
                        outputBurrow[1] = row;
                    }
                }
            }
            while (foodQuattity < 10)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    snakePosition[0] -= 1;
                    matrix[snakePosition[0] + 1, snakePosition[1]] = '.';
                    matrix[snakePosition[0], snakePosition[1]] = 'S';
                    snakePosition = IsInBarrow(snakePosition, inputBurrow, outputBurrow);
                    //find a way to replace S in matrix with other posisons of barrew and second barrew replace with "."
                   
                }
            }



        }
        static int[] IsInBarrow(int[]snakePosition,int[] firstBarre, int[] secondBarrew)
        {
            if (snakePosition[0] == firstBarre[0] && snakePosition[1] == firstBarre[1])
            {
                snakePosition[0] = secondBarrew[0];
                snakePosition[1] = secondBarrew[1];
            }
            else if (snakePosition[0] == secondBarrew[0] && snakePosition[1] == secondBarrew[1])
            {
                snakePosition[0] = secondBarrew[0];
                snakePosition[1] = secondBarrew[1];
            }
            return snakePosition;
        }
        static void MoveUp()
        {

        }
        static bool IsInRange(int n, int col, int row)
        {
            if ((col >= 0 && col < n) && (row >= 0 && row < n))
            {
                return true;
            }
            return false;
        }
    }
}
