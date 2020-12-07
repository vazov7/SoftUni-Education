using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int totalCapacity = 0;
            while (count !=n)
            {
                int enterLitres = int.Parse(Console.ReadLine());
                totalCapacity += enterLitres;
                if (totalCapacity > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalCapacity -= enterLitres;
                }
                count++;
            }
            Console.WriteLine(totalCapacity);
        }
    }
}
