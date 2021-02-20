using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightforGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            List<string> commands = Console.ReadLine().Split(",").ToList();
            int firstPlayerShipsCount = 0;
            int secondPlayerShipsCount = 0;
            for (int col = 0; col < n; col++)
            {
                List<char> field = Console.ReadLine().Split().Select(char.Parse).ToList();

                for (int row = 0; row < n; row++)
                {
                    matrix[col, row] = field[row];
                    if (field[row] == '>')
                    {
                        secondPlayerShipsCount++;
                    }
                    else if (field[row] == '<')
                    {
                        firstPlayerShipsCount++;
                    }
                }
            }

            while (commands.Count != 0)
            {
                for (int i = 0; i < commands.Count; i++)
                {
                    int[] command = commands.FirstOrDefault().Split().Select(int.Parse).ToArray();
                    commands.RemoveAt(0);
                    if (!IsInRange(n, command[0], command[1]))
                    {
                        continue;
                    }
                    if (i % 2 == 0)
                    {//firstship

                        int[] temp = new int[2];
                        if (matrix[command[0], command[1]] == '>')
                        {
                            matrix[command[0], command[1]] = 'X';
                            secondPlayerShipsCount--;
                        }
                        else if (matrix[command[0], command[1]] == '#')
                        {
                            if (matrix[command[0]-1,command[1]] =='<')
                            {
                                firstPlayerShipsCount--;
                                matrix[command[0] - 1, command[1]] = 'X';
                            }
                            else if (matrix[command[0] - 1, command[1]] == '>')
                            {
                                secondPlayerShipsCount--;
                                matrix[command[0] - 1, command[1]] = 'X';
                            }

                            if (matrix[command[0] - 1, command[1]-1] == '<')
                            {
                                firstPlayerShipsCount--;
                                matrix[command[0] - 1, command[1]-1] = 'X';
                            }
                            else if (matrix[command[0] - 1, command[1]-1] == '>')
                            {
                                secondPlayerShipsCount--;
                                matrix[command[0] - 1, command[1]-1] = 'X';
                            }
                            if (matrix[command[0] - 1, command[1] - 1] == '<')
                            {
                                firstPlayerShipsCount--;
                                matrix[command[0] - 1, command[1] - 1] = 'X';
                            }
                            else if (matrix[command[0] - 1, command[1] - 1] == '>')
                            {
                                secondPlayerShipsCount--;
                                matrix[command[0] - 1, command[1] - 1] = 'X';
                            }
                        }
                            
                        }
                    }
                }
            }

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
