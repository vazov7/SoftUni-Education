using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumpition;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; } 
        }
        public double FuelConsumption
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public void Drive(double distance)
        {
            
            if (fuelQuantity - (distance * FuelConsumption) > 0)
            {
                fuelQuantity -= (distance * FuelConsumption);
            }
            else 
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            string output = $"Make: {this.make}\nModel: {this.model}\nYear: {this.year}\nFuel: {this.fuelQuantity:F2}L";
            return output;
        }


    }
}
