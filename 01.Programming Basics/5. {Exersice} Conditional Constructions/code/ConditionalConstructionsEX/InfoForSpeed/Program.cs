using System;

namespace InfoForSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            //read real number from console
            double num = double.Parse(Console.ReadLine());
            // speed to <= 10 write > slow || to <= 50 write > average || to <= 150 fast || to <= 1000 write ultra fast||default extremely fast
            if (num <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (num <= 50)
            {
                Console.WriteLine("average");
            }
            else if (num <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (num <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
