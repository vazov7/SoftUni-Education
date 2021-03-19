using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shapes
    {
        public Rectangle(double height,double width)
        {
            Height = height;
            Width = width;
        }
        private double Height; 
        private double Width; 

        public override double CalculateArea()
        {
            return 2.2;
        }

        public override double CalculatePerimeter()
        {
            return 2.3;
        }
        public override string Draw()
        {
            return "neshto koeto prilicha na truiugulnik";
        }
    }
}
