using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read from console L - {length} , W - width of the hall in meters and A - side of the wardrobe in meters
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());
            //calculate Hall size in centimeters > (L*100)*(W*100)
            double hallSize = (length * 100) * (width * 100);
            //calculate Size of the wardrobe > (A*100)*(A*100)
            double wardrobeSize = (wardrobeSide * 100) * (wardrobeSide * 100);
            //calcuate size of bench > hallSize / 10
            double benchSize = hallSize / 10;
            //Free space > hallSize - (wardrobeSize + benchSize)
            double freeSpace = hallSize - (wardrobeSize + benchSize);
            //calculate number of dancers > freeSpace / (40 + 7000)
            double dancersNum = freeSpace / (40 + 7000);
            //Write to console Number of Dancer in hall
            Console.WriteLine(Math.Floor(dancersNum));

        }
    }
}
