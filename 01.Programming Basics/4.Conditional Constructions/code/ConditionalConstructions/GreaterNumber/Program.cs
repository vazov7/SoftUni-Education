using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from conosole 2 int numbers
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            //Write "Greater Number: "
            if (firstNumber < secondNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else 
            {
                Console.WriteLine(firstNumber);
            }
            //Prints the bigger number
        }
    }
}

