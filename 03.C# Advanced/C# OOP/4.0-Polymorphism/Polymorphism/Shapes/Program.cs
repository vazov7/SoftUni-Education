using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shapes rectangle = new Rectangle(2.2,3.3);
            Console.WriteLine(rectangle.Draw());
            Shapes circle = new Circle(55.5);
            Console.WriteLine(circle.Draw());
        }
    }
}
