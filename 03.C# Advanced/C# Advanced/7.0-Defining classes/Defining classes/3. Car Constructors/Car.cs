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
        public Car()
        {
            this.make = "VW";
            this.model = "Golf";
            this.year = 2025;
            this.fuelQuantity = 200;
            this.fuelConsumpition = 10;
        }
        public Car(string make, string model, int year)
            : this()
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        public Car(string make ,string model, int year, double fuelQuantity, double fuelConsumption)
            :this (make,model,year)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumpition = fuelConsumption;
        }
    }
}
