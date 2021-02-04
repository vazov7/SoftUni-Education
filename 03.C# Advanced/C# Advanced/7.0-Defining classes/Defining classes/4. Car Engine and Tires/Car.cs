using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private Engine engine;
        private Tire[] tires;
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumpition;
        public Engine Engine{ get; set; }
        public Tire[] Tires { get; set; }
        public int HousePower { get; set; }
        public double CubicCapacity { get; set; }


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
    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        : this(make, model, year)
    {
        this.fuelQuantity = fuelQuantity;
        this.fuelConsumpition = fuelConsumption;
    }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            :this(make,  model,  year, fuelQuantity, fuelConsumption)
        {
            this.engine = engine;
            this.tires = tires;
        }
}
}
