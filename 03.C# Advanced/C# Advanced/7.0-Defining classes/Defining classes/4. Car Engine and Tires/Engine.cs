using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
   public  class Engine
    {
        private int housePower;
        private double cubicCapacity;
        public int HousePower 
        {
            get { return this.housePower; }
            set { this.housePower = value; }

        }
        public double CubicCapacity
        {
            get { return this.cubicCapacity; }
            set { this.cubicCapacity = value; }
        }

        public Engine(int housePowers, double cubicCapacity)
        {
            this.housePower = housePowers;
            this.cubicCapacity = cubicCapacity;
        }

    }
}
