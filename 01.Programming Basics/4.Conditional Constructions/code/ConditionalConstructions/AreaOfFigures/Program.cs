using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console figure
            string figure = Console.ReadLine();
            //make if else square, rectangle, circle или triangle
            //calculate square area / read one number{hinght of his side}
            if (figure == "square")
            {
                double sqareSide = double.Parse(Console.ReadLine());
                double sqareArea = sqareSide *  sqareSide;
                Console.WriteLine($"{sqareArea:F3}");
            }
            else if (figure == "rectangle") //calculate rectangle area / read two numbers height and width{read 2 sides }
            {
                double rectangleHeight = double.Parse(Console.ReadLine());
                double rectangleWidth = double.Parse(Console.ReadLine());
                double rectangleArea = rectangleWidth * rectangleHeight;
                Console.WriteLine($"{rectangleArea:F3}");
            }
            else if (figure == "circle")   //calculate circle area / read one number{radius of circle}
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * (circleRadius * circleRadius);
                Console.WriteLine($"{circleArea:F3}");
            }  
            else  if (figure == "triangle")  //calculate triangle area / read two numbers{the Base of side and length of the height }
            {
                double triangleBase = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());
                double triangleArea = triangleBase * triangleHeight / 2;
                Console.WriteLine($"{triangleArea:F3}");
            }
            //write to console answer F3
        }
    }
}
