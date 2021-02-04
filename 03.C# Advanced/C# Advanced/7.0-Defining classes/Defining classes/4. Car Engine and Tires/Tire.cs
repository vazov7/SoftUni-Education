using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double preassure;
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }

        }
        public double Preassure
        {
            get { return this.preassure; }
            set { this.preassure = value; }
        }

        public Tire(int year, double preassure)
        {
            this.year = year;
            this.preassure = preassure;
        }
    }
}
