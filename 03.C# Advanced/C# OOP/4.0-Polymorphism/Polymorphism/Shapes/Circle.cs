using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shapes
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        private double Radius;
        public override double CalculateArea()
        {
            return 4.4;
        }

        public override double CalculatePerimeter()
        {
            return 4.5;
        }
        public override string Draw()
        {
            return "neshto podobno => () <= (towa e krug)";
        }
    }
}
