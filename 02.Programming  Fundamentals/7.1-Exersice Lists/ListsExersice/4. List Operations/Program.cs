using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().ToLower().Split().ToList();
            while (command[0] != "end")
            {
                //•	Add {number} – add number at the end.
                if (command[0] == "add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                //•	Insert {number} {index} – insert number at given index.
                else if (command[0] == "insert")
                {
                    if (int.Parse(command[2]) > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    }
                }
                //•	Remove {index} – remove at index.
                else if (command[0] == "remove")
                {
                    if (int.Parse(command[1]) > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(command[1]));
                    }
                }
                //•	Shift left {count} – first number becomes last ‘count’ times.
                else if (command[0] == "shift")
                {
                    int count = int.Parse(command[2]);
                    if (command[1] == "left")
                    {

                        for (int i = 0; i < count; i++)
                        {
                            int firstNum = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = firstNum;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNum = numbers[numbers.Count - 1];
                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }
                            numbers[0] = lastNum;
                        }
                    }
                }
                command = Console.ReadLine().ToLower().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
