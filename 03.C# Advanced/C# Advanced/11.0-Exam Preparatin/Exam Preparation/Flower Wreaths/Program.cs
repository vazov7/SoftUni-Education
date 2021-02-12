using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            int wreath = 0;
            int flowers = 0;
            while (lilies.Count > 0 && roses.Count > 0)
            {
                int lilia = lilies.Pop();
                int rose = roses.Dequeue();
                int sum = lilia + rose;
                if (sum == 15)
                {
                    wreath++;
                }
                else if (sum < 15)
                {
                    flowers += sum;
                }
                else if (sum > 15)
                {
                    while (sum > 15)
                    {
                        sum -= 2;
                        if (sum == 15)
                        {
                            wreath++;
                        }
                        else if (sum < 15)
                        {
                            flowers += sum;
                        }
                    }
                }
            }
            wreath += flowers / 15;

            if (wreath >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreath} wreaths!" );
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreath} wreaths more!");
            }
        }
    }
}
