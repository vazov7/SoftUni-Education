using System;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            FindPower(num, power);
        }
        static void FindPower(double num, int power)
        {
            
           // for (int i = 0; i <= power; i++)
                Console.WriteLine($"{(long)Math.Pow(num, power)}");
            
        }
    }
}
