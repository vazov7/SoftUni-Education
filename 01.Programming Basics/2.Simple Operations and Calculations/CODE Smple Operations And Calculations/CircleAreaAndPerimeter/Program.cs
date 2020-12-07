using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //read Radius from console
            double radius =  double.Parse(Console.ReadLine());

            //calculate r to area and Perimeter
            double area = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius;

            //Write to consosle answers
            Console.WriteLine("{0:f2}", area);
            Console.WriteLine("{0:f2}", perimeter);
        }
    }
}
