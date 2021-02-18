using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    public class Program
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
            List<string> foodPositions = new List<string>();

            for (int col = 0; col < n; col++)
            {
                string inputRow = Console.ReadLine();
                for (int row = 0; row < inputRow.Length; row++)
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
                    if (inputRow[row] == '*')
                    {
                        foodPositions.Add($"{col} {row}");
                    }
                }
            }



            while (foodQuattity < 10)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    snakePosition[0] -= 1;
                    if (!IsInRange(n, snakePosition[0], snakePosition[1]))
                    {
                        matrix[snakePosition[0] + 1, snakePosition[1]] = '.';
                        break;
                    }

                    matrix[snakePosition[0] + 1, snakePosition[1]] = '.';
                    matrix[snakePosition[0], snakePosition[1]] = 'S';
                    if (foodPositions.Contains($"{snakePosition[0]} {snakePosition[1]}"))
                    {
                        foodPositions.Remove($"{snakePosition[0]} {snakePosition[1]}");
                        foodQuattity++;
                    }

                    int[] temp = new int[]
                    {
                        snakePosition[0],
                        snakePosition[1]
                    };
                    snakePosition = IsInBarrow(snakePosition, inputBurrow, outputBurrow);
                    if (!(snakePosition[0] == temp[0] && snakePosition[1] == temp[1]))
                    {
                        matrix[temp[0], temp[1]] = '.';
                        matrix[snakePosition[0], snakePosition[1]] = 'S';

                    }

                }
                else if (command == "down")
                {
                    snakePosition[0] += 1;
                    if (!IsInRange(n, snakePosition[0], snakePosition[1]))
                    {
                        matrix[snakePosition[0] - 1, snakePosition[1]] = '.';
                        break;
                    }
                    matrix[snakePosition[0] - 1, snakePosition[1]] = '.';
                    matrix[snakePosition[0], snakePosition[1]] = 'S';
                    if (foodPositions.Contains($"{snakePosition[0]} {snakePosition[1]}"))
                    {
                        foodPositions.Remove($"{snakePosition[0]} {snakePosition[1]}");
                        foodQuattity++;
                    }
                    int[] temp = new int[]
                    {
                        snakePosition[0],
                        snakePosition[1]
                    };
                    snakePosition = IsInBarrow(snakePosition, inputBurrow, outputBurrow);
                    if (!(snakePosition[0] == temp[0] && snakePosition[1] == temp[1]))
                    {
                        matrix[temp[0], temp[1]] = '.';
                        matrix[snakePosition[0], snakePosition[1]] = 'S';
                    }
                }
                else if (command == "left")
                {
                    snakePosition[1] -= 1;
                    if (!IsInRange(n, snakePosition[0], snakePosition[1]))
                    {
                        matrix[snakePosition[0], snakePosition[1] + 1] = '.';
                        break;
                    }
                    matrix[snakePosition[0], snakePosition[1] +1] = '.';
                    matrix[snakePosition[0], snakePosition[1]] = 'S';
                    if (foodPositions.Contains($"{snakePosition[0]} {snakePosition[1]}"))
                    {
                        foodPositions.Remove($"{snakePosition[0]} {snakePosition[1]}");
                        foodQuattity++;
                    }
                    int[] temp = new int[]
                    {
                        snakePosition[0],
                        snakePosition[1]
                    };
                    snakePosition = IsInBarrow(snakePosition, inputBurrow, outputBurrow);
                    if (!(snakePosition[0] == temp[0] && snakePosition[1] == temp[1]))
                    {
                        matrix[temp[0], temp[1]] = '.';
                        matrix[snakePosition[0], snakePosition[1]] = 'S';
                    }

                }
                else if (command == "right")
                {
                    snakePosition[1] += 1;
                    if (!IsInRange(n, snakePosition[0], snakePosition[1]))
                    {
                        matrix[snakePosition[0], snakePosition[1] + 1] = '.';
                        break;
                    }
                    matrix[snakePosition[0], snakePosition[1] - 1] = '.';
                    matrix[snakePosition[0], snakePosition[1]] = 'S';

                    if (foodPositions.Contains($"{snakePosition[0]} {snakePosition[1]}"))
                    {
                        foodPositions.Remove($"{snakePosition[0]} {snakePosition[1]}");
                        foodQuattity++;
                    }
                    int[] temp = new int[]
                    {
                        snakePosition[0],
                        snakePosition[1]
                    };
                    snakePosition = IsInBarrow(snakePosition, inputBurrow, outputBurrow);
                    if (!(snakePosition[0] == temp[0] && snakePosition[1] == temp[1]))
                    {
                        matrix[temp[0], temp[1]] = '.';
                        matrix[snakePosition[0], snakePosition[1]] = 'S';
                    }

                }
            }
            if (!IsInRange(n, snakePosition[0], snakePosition[1]))
            {

                Console.WriteLine("Game over!");
            }
            else if (foodQuattity >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");

            }
            Console.WriteLine($"Food eaten: {foodQuattity}");

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write(matrix[col,row]);
                }
                Console.WriteLine();
            }


        }
        static int[] IsInBarrow(int[] snakePosition, int[] firstBarre, int[] secondBarrew)
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

        static bool IsInRange(int n, int col, int row)
        {
           
            // 5
            if ((col >= 0 && col < n) && (row >= 0 && row < n))
            {
                return true;
            }
            return false;
        }
    }
}
