using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Car
    {
        public Car(string manfucatirer, string model, int year)
        {
            Manufacturer = manfucatirer;
            Model = model;
            Year = year;
        }
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }
        //manufacturer, model and yea
        public override string ToString()
        {
            return $"{this.Manufacturer} {this.Model} ({this.Year})";
        }
    }
    
    
}
