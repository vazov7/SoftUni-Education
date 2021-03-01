using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        public Box(double a, double b, double c)
        {
            this.Lenght = a;
            this.Width = b;
            this.Height = c;
        }
        private double lenght;
        private double width;
        private double height;

        public double Lenght
        {
            get => this.lenght;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }
                else
                {
                    this.lenght = value;
                }
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                else
                {
                    this.height = value;
                }
            }
        }
        public double CalculateValue()
        {
            return this.Width * this.Lenght * this.Height;
        }
        public double CalculateLateralSurfaceArea()
        {
            return 2 * Lenght * Height + 2 * Width * Height;
        }
        public double CalculateSurfaceArea()
        {
            return 2 * Lenght * Width + 2 * Lenght * Height + 2 * Width * Height;
        }
    }
}
