using System;

namespace _11.Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char command = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (command == '/')
            {
                DivisionNums(firstNum, secondNum);
            }
            else if (command == '*')
            {
                MultiplyNums(firstNum, secondNum);

            }
            else if (command == '-')
            {
                SubtractNums(firstNum, secondNum);

            }
            else if (command == '+')
            {
                AddNums(firstNum, secondNum);

            }

        }
        static void DivisionNums(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }
        static void MultiplyNums(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }
        static void AddNums(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
        static void SubtractNums(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }

    }
}
