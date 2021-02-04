using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = "VW";
            string model = "Golf";
            int year = 2025;
            double fuelQuantity = 200;
            double fuelConsumpition = 10;

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumpition);

        }
    }
}
