using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string cmd = Console.ReadLine();
            while (cmd != "Finish")
            {
                List<string> cmdList = cmd.Split().ToList();
                string command = cmdList[0];
                if (command == "Replace")
                {
                    char currChar = char.Parse(cmdList[1]);
                    char replaceChar = char.Parse(cmdList[2]);
                    Console.WriteLine($"{input = input.Replace(currChar, replaceChar)}");
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(cmdList[1]);
                    int endIndex = int.Parse(cmdList[2]);
                    if (startIndex > 0 && endIndex < input.Length)
                    {//this is Valid
                        input = input.Remove(startIndex, (endIndex));
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }

                }
                else if (command == "Make")
                {
                    string upperOrLower = cmdList[1];
                    if (upperOrLower == "Upper")
                    {
                        input = input.ToUpper();
                        
                    }
                    else if (upperOrLower == "Lower")
                    {
                        input = input.ToLower();
                        
                    }
                    Console.WriteLine(input);
                }
                else if (command == "Check")
                {
                    string checkString = cmdList[1];
                    if (input.Contains(checkString))
                    {
                        Console.WriteLine($"Message contains {checkString}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {checkString}");
                    }

                }
                else if (command == "Sum")
                {
                    int startIndex = int.Parse(cmdList[1]);
                    int endIndex = int.Parse(cmdList[2]);
                    if (startIndex > 0 && endIndex < input.Length)
                    {

                        string substring = input.Substring(startIndex, endIndex);
                        int sum = input.Substring(startIndex, endIndex)
                            .ToString()
                            .ToCharArray()
                            .Sum(x => (int)x);
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }

                cmd = Console.ReadLine();
            }
        }
    }
}
