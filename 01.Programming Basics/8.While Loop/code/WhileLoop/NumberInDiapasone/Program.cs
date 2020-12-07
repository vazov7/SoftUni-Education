using System;

namespace NumberInDiapasone
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            while (number > 100 || number < 1)
            {
                Console.WriteLine("Invalid number!");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: " + number);
        }
    }
}
