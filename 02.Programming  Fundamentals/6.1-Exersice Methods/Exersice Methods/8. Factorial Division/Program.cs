using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal firstFactorial = FindFactorial(firstNumber);
            decimal secondFactorial = FindFactorial(secondNumber);
            decimal divideFactorials = firstFactorial / secondFactorial;
            Console.WriteLine($"{divideFactorials:f2}");
        }
        static decimal FindFactorial(decimal number)
        {
            decimal fact = number;
            for (decimal i = number - 1; i >= 1; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
