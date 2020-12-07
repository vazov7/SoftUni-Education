using System;

namespace ThreeEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console 3 numbers
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            //convert hum to equal or not
            if (firstNumber == secondNumber && secondNumber == thirdNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
