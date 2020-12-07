using System;

namespace _6._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double result = Calculating(firstNum, secondNum);
            Console.WriteLine(result);

        }
        static double Calculating(double firstN, double secondN)
        {
            double result = firstN * secondN;
            return result;
        }
    }
    
}
