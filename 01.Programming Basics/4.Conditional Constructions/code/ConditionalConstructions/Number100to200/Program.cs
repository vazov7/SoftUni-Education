using System;

namespace Number100to200
{
    class Program
    {
        static void Main(string[] args)
        {
            //read int number from console
            int number = int.Parse(Console.ReadLine());
            //check it whether it is below 100, between 100-200, or up  200
            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
            //and print the messages - Less than 100 - Between 100 and 200 - Greater than 200
        }
    }
}
