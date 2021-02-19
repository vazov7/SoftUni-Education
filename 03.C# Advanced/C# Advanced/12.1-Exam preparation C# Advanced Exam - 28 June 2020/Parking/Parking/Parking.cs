using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parking
{
    class Parking
    {
        private List<Car> data { get; }
        public string Type{ get; set; }
        public int Capacity{ get; set; }
        public int Count { get { return this.data.Count; } }
        public Parking(string type, int capacity)
        {
            data = new List<Car>(capacity);
            this.Type = type;
            this.Capacity = capacity;
        }
        public void Add(Car car)
        {
            if (data.Count < this.Capacity)
            {
                data.Add(car);
            }
        }
        //•	Method Remove(string manufacturer, string model) – removes the car by given manufacturer and model, if such exists, and returns bool.
        public bool Remove(string manfacturer, string model)
        {
            foreach (Car item in data)
            {
                if (item.Manufacturer == manfacturer && item.Model == model)
                {
                    this.data.Remove(item);
                    return true;
                }
            }
            return false;
        }
        //•	Method GetLatestCar() – returns the latest car (by year) or null if have no cars.
        public Car GetLatestCar()
        {
            //if (data.Any())
            //{
            //    List<Car> sorted = data.OrderBy(c => c.Year).ToList();
            //    return sorted[sorted.Count - 1];
            //}
            //return null;
            return data.OrderByDescending(c => c.Year).FirstOrDefault();
        }
        //•	Method GetCar(string manufacturer, string model) – returns the car with the given manufacturer and model or null if there is no such car.
        public Car GetCar(string manfacturer, string model)
        {
            foreach (Car item in data)
            {
                if (item.Manufacturer == manfacturer && item.Model == model)
                {
                    return item; 
                }
            }
            return null;
        }
        //        •	GetStatistics() – returns a string in the following format:
        //o	"The cars are parked in {parking type}:
        //{Car1
        //    }
        //{Car2
        //}
        //(…)"

        public string GetStatistics()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"The cars are parked in {Type}:");
            foreach (Car car in this.data)
            {
                output.AppendLine($"{car}");


            }
            return output.ToString();
        }

    }
}
