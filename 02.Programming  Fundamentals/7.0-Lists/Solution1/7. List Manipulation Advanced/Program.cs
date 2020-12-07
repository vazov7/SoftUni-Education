using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            bool isChanged = false;

            List<string> command = command = Console.ReadLine().ToLower().Split().ToList();
            while (command[0] != "end")
            {

                switch (command[0])
                {
                    case "add":
                        numbers.Add(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "remove":
                        numbers.Remove(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "removeat":
                        numbers.RemoveAt(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "contains":
                        string answer = string.Empty;
                        answer = numbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number";
                        Console.WriteLine(answer);
                        break;
                    case "printeven":
                        int[] evenNums = numbers.Where(n => n % 2 == 0).ToArray();
                        Console.WriteLine(string.Join(" ", evenNums));
                        break;
                    case "printodd":
                        int[] oddNums = numbers.Where(n => n % 2 == 1).ToArray();
                        Console.WriteLine(string.Join(" ", oddNums));
                        break;
                    case "getsum":
                        double sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "filter":
                        switch (command[1])
                        {
                            case "<":
                                int[] smallNums = numbers.Where(n => n < numbers[2]).ToArray();
                                Console.WriteLine(string.Join(" ", smallNums));
                                break;
                            case ">":
                                int[] biggerNums = numbers.Where(n => n > numbers[2]).ToArray();
                                Console.WriteLine(string.Join(" ", biggerNums));
                                break;
                            case "<=":
                                int[] n2 = numbers.Where(n => n <= numbers[2]).ToArray();
                                Console.WriteLine(string.Join(" ", n2));
                                break;
                            case ">=":
                                int[] n1 = numbers.Where(n => n >= numbers[2]).ToArray();
                                Console.WriteLine(string.Join(" ", n1));
                                break;
                            default:
                                break;
                        }
                        break;


                    default:
                        break;
                }
                command = Console.ReadLine().ToLower().Split().ToList();
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));

            }
        }
    }
}
