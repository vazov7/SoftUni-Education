using System;

namespace SquareDoubleIntArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //get number from console
            double squareSide = Double.Parse(Console.ReadLine());

            //calculate number
            double squareSideArea = squareSide * squareSide;

            //write number to console
            Console.WriteLine(squareSideArea);
        }
    }
}
