using System;

namespace _3_Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grate = double.Parse(Console.ReadLine());

            if (grate >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else if (grate <= 2.99)
            {
                Console.WriteLine("Failed!");
            }

        }
    }
}
