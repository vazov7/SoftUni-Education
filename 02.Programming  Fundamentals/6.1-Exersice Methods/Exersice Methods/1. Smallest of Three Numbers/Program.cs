﻿using System;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            FindSmallestNum(firstNum, secondNum, thirdNum);
        }
        static void FindSmallestNum(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum < secondNum && firstNum < thirdNum)
            {
                Console.WriteLine(firstNum);
            }
            else if (secondNum < firstNum && secondNum < thirdNum)
            {
                Console.WriteLine(secondNum);
            }
            else if (thirdNum < firstNum && thirdNum < secondNum)
            {
                Console.WriteLine(thirdNum);
            }
        }
    }
}
