using System;

namespace _5._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sumFromAdd = AddNumbers(firstNum, secondNum);
            double sumFromSubtract = AddNumbers(firstNum, secondNum) - thirdNum;
            Console.WriteLine(sumFromSubtract);
        }

        private static int AddNumbers(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }
    }
}
