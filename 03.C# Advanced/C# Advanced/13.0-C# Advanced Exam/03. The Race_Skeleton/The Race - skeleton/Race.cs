using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data { get; }
        public string Name { get; set; }
        public int Capacity{ get; set; }
        public int Count { get { return this.data.Count; } }
        public Race(string name,int capacity)
        {
            data = new List<Racer>();
            Name = name;
            Capacity = capacity;
        }
        //•	Method Add(Racer Racer) – adds an entity to the data if there is room for him/her.
        public void Add(Racer racer)
        {
            if (data.Count < this.Capacity)
            {
                data.Add(racer);
            }
        }
        //•	Method Remove(string name) – removes an Racer by given name, if such exists, and returns bool.
        public bool Remove(string name)
        {
            foreach (Racer item in data)
            {
                if (item.Name== name)
                {
                    this.data.Remove(item);
                    return true;
                }
            }
            return false;
        }
        //•	Method GetOldestRacer() – returns the oldest Racer.
        public Racer GetOldestRacer()
        {
           
            return data.OrderByDescending(c => c.Age).FirstOrDefault();
        }
        //•	Method GetRacer(string name) – returns the Racer with the given name
        public Racer GetRacer(string name)
        {
            foreach (Racer item in data)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
        //•	Method GetFastestRacer() – returns the Racer whose car has the highest speed.
        public Racer GetFastestRacer()
        {

            return data.OrderByDescending(c => c.Car.Speed).FirstOrDefault();
        }
        //•	Report() – returns a string in the following format:
        public string Report()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Racers participating at {Name}:");
            foreach (Racer car in this.data)
            {
                output.AppendLine($"{car}");
            }
            return output.ToString();
        }
    }
}
