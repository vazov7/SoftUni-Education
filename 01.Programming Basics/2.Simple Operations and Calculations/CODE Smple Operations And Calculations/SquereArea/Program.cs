using System;

namespace SquereArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console "side"
            int side = int.Parse(Console.ReadLine());

            //calculate side*side
            int area = side * side;

            //write to console solution
            Console.WriteLine(area);
        }
    }
}
