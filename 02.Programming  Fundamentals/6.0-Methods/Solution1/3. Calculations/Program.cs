using System;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                CommandAdd(firstNum, secondNum);
            }
            else if (command == "multiply")
            {
                CommandMultiply(firstNum, secondNum);
            }
            else if (command == "subtract")
            {
                CommandSubtract(firstNum, secondNum);
            }
            else if (command == "divide")
            {
                CommandDivide(firstNum, secondNum);
            }
        }
        static void CommandAdd(int firstNum, int secondNum)
        {
            firstNum += secondNum;
            Console.WriteLine(firstNum);
        }
        static void CommandMultiply(int firstNum, int secondNum)
        {
            firstNum *= secondNum;
            Console.WriteLine(firstNum);
        }
        static void CommandDivide(int firstNum, int secondNum)
        {
            double result = firstNum / secondNum;
            Console.WriteLine($"{result}");
        }
        static void CommandSubtract(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            Console.WriteLine($"{result}");
        }
    }

}