using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //get number from console
            int squareSide = int.Parse(Console.ReadLine());

            //calculate number
            int squareSideArea = squareSide * squareSide;

            //write number to console
            Console.WriteLine(squareSideArea);
        }
    }
}
