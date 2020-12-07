using System;

namespace _6_Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int factorialSum = 0;
            int checkNum = 0;
            int num1 = num;
            
            while (num1 != 0)
            {
                int factorial = 1;
                checkNum = num1 % 10;
                for (int i = 1; i <= checkNum; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
                num1 /= 10;
            }
            string check = string.Empty;
            if (factorialSum == num)
            {
                check = "yes";
            }
            else
            {
                check = "no";
            }
            Console.WriteLine(check);

        }
    }
}
