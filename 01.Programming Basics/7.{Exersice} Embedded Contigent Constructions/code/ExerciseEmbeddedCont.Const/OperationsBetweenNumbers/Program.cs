using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = int.Parse(Console.ReadLine());
            double secoundNumber = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());


            double sum = 0.0;

            if (symbol == '+' || symbol == '-' || symbol == '*')
            {
                string evenOrOdd = string.Empty;
                if (symbol == '+')
                {
                    sum = firstNumber + secoundNumber;
                }
                else if (symbol == '-')
                {
                    sum = firstNumber - secoundNumber;
                }
                else if (symbol == '*')
                {
                    sum = firstNumber * secoundNumber;
                }
                if (sum % 2 == 0)
                    evenOrOdd = "even";
                else if (sum % 2 == 1)
                    evenOrOdd = "odd";
                Console.WriteLine($"{firstNumber} {symbol} {secoundNumber} = {sum} - {evenOrOdd}");
            }
            else if (symbol == '/' && secoundNumber != 0)
            {
                sum = firstNumber / secoundNumber;
                Console.WriteLine($"{firstNumber} / {secoundNumber} = {sum:F2}");
            }
            else if (symbol == '%' && secoundNumber != 0)
            {
                sum = firstNumber % secoundNumber;
                Console.WriteLine($"{firstNumber} % {secoundNumber} = {sum}");
            }
            else if (secoundNumber == 0)
            {
                Console.WriteLine($"Cannot divide {firstNumber} by zero");
            }


        }
    }
}