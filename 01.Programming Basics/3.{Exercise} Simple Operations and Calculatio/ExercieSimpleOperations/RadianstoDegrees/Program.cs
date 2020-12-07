using System;

namespace RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {

            //Read radians From Console
            double radians = double.Parse(Console.ReadLine());
            //Convert degrees > radians * 180 /P
            double degrees = radians * 180 / Math.PI;
            //Print > round
            Console.WriteLine(Math.Round(degrees));

        }
    }
}
