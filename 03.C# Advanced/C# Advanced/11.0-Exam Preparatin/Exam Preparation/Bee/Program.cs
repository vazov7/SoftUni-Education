using System;

namespace Bee
{
    class Program
    {
        
       static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int[] indexOfBee = new int[2];
            int[] bonusIndex = new int[2];
            for (int col = 0; col < n; col++)
            {
                string input = Console.ReadLine();
                for (int row = 0; row < n; row++)
                {
                    matrix[col, row] = input[row];
                    if (input[row] == 'B')
                    {
                        indexOfBee[0] = col;
                        indexOfBee[1] = row;
                    }
                    if (input[row] == 'O')
                    {
                        bonusIndex[0] = col;
                        bonusIndex[1] = row;
                    }
                }
            }
            int pollinateFlowers = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                if (command == "up")
                {
                    indexOfBee[0] = indexOfBee[0] - 1;
                    if (IsInRange(n, indexOfBee[0], indexOfBee[1]))
                    {
                        if (matrix[indexOfBee[0], indexOfBee[1]] == 'O')
                        {
                            indexOfBee[0] = indexOfBee[0] - 1;
                            if (!IsInRange(n, indexOfBee[0], indexOfBee[1]))
                                break;

                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0] + 1, indexOfBee[1]] = '.';
                            if (matrix[indexOfBee[0], indexOfBee[1]] == 'f')
                            {

                                pollinateFlowers++;
                                matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                                matrix[indexOfBee[0] + 1, indexOfBee[1]] = '.';
                            }
                            else
                            {
                                matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                                matrix[indexOfBee[0] + 1, indexOfBee[1]] = '.';
                            }

                        }
                        else if (matrix[indexOfBee[0], indexOfBee[1]] == 'f')
                        {

                            pollinateFlowers++;
                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0] + 1, indexOfBee[1]] = '.';
                        }
                        else
                        {
                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0] + 1, indexOfBee[1]] = '.';
                        }
                    }
                    else
                    {
                        break;
                    }

                }
                else if (command == "down")
                {
                    indexOfBee[0] = indexOfBee[0] + 1;
                    if (IsInRange(n, indexOfBee[0], indexOfBee[1]))
                    {
                        if (matrix[indexOfBee[0], indexOfBee[1]] == 'O')
                        {
                            
                            indexOfBee[0] = indexOfBee[0] + 1;
                            if (!IsInRange(n, indexOfBee[0], indexOfBee[1]))
                                break;
                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0] - 1, indexOfBee[1]] = '.';
                            if (matrix[indexOfBee[0], indexOfBee[1]] == 'f')
                            {

                                pollinateFlowers++;
                                matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                                matrix[indexOfBee[0] - 1, indexOfBee[1]] = '.';
                            }
                            else
                            {
                                matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                                matrix[indexOfBee[0] + 1, indexOfBee[1]] = '.';
                            }

                        }
                        else if (matrix[indexOfBee[0], indexOfBee[1]] == 'f')
                        {

                            pollinateFlowers++;
                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0] - 1, indexOfBee[1]] = '.';
                        }
                        else
                        {
                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0] - 1, indexOfBee[1]] = '.';
                        }
                    }
                    else
                    {
                        break;
                    }

                }
                else if (command == "left")
                {
                    indexOfBee[1] = indexOfBee[1] - 1;
                    if (IsInRange(n, indexOfBee[0], indexOfBee[1]))
                    {
                        if (matrix[indexOfBee[0], indexOfBee[1]] == 'O')
                        {
                          
                            indexOfBee[1] = indexOfBee[1] - 1;
                            if (!IsInRange(n, indexOfBee[0], indexOfBee[1]))
                                break;

                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0], indexOfBee[1] + 1] = '.';
                            if (matrix[indexOfBee[0], indexOfBee[1]] == 'f')
                            {

                                pollinateFlowers++;
                                matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                                matrix[indexOfBee[0], indexOfBee[1] + 1] = '.';
                            }
                            else
                            {
                                matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                                matrix[indexOfBee[0], indexOfBee[1] + 1] = '.';
                            }

                        }
                        else if (matrix[indexOfBee[0], indexOfBee[1]] == 'f')
                        {

                            pollinateFlowers++;
                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0], indexOfBee[1] + 1] = '.';
                        }
                        else
                        {
                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0], indexOfBee[1] + 1] = '.';
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else if (command == "right")
                {
                    indexOfBee[1] = indexOfBee[1] + 1;
                    if (IsInRange(n, indexOfBee[0], indexOfBee[1]))
                    {

                        if (matrix[indexOfBee[0], indexOfBee[1]] == 'O')
                        {
                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0], indexOfBee[1] - 1] = '.';
                            indexOfBee[1] = indexOfBee[1] + 1;
                            if (!IsInRange(n, indexOfBee[0], indexOfBee[1]))
                                break;

                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0], indexOfBee[1] - 1] = '.';
                            if (matrix[indexOfBee[0], indexOfBee[1]] == 'f')
                            {

                                pollinateFlowers++;
                                matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                                matrix[indexOfBee[0], indexOfBee[1] - 1] = '.';
                            }
                            else
                            {
                                matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                                matrix[indexOfBee[0], indexOfBee[1] - 1] = '.';
                            }

                        }
                        else if (matrix[indexOfBee[0], indexOfBee[1]] == 'f')
                        {

                            pollinateFlowers++;
                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0], indexOfBee[1] - 1] = '.';
                        }
                        else
                        {
                            matrix[indexOfBee[0], indexOfBee[1]] = 'B';
                            matrix[indexOfBee[0], indexOfBee[1] - 1] = '.';
                        }
                    }
                    else
                    {
                        break;
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
