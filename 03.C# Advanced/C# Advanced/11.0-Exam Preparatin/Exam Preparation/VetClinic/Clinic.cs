using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> items;
        private int cpacity;
        public Clinic(int capacity)
        {
            items = new List<Pet>(capacity);
            this.cpacity = capacity;
        }
        //•	Method Add(Pet pet) – adds an entity to the data if there is an empty cell for the pet.
        public void Add(Pet pet)
        {
            if (this.items.Count < cpacity)
            {
                this.items.Add(pet);
            }
        }
        //•	Method Remove(string name) – removes the pet by given name, if such exists, and returns bool.
        public bool Remove(string name)
        {

            foreach (Pet pet in this.items)
            {
                if (pet.Name == name)
                {
                    items.Remove(pet);
                    return true;
                }
            }
            return false;
        }
        //•	Method GetPet(string name, string owner) – returns the pet with the given name and owner or null if no such pet exists.
        public Pet GetPet(string name, string owner)
        {

            foreach (Pet pet in items)
            {
                if (pet.Name == name && pet.Owner == owner)
                {
                    return pet;
                }
            }
            return null;
        }
        //•	Method GetOldestPet() – returns the oldest Pet
        public Pet GetOldestPet()
        {
            Pet oldestPet = new Pet(" ", -1, " ");
            foreach (Pet pet in this.items)
            {
                if (pet.Age > oldestPet.Age)
                {
                    oldestPet = pet;
                }
            }
            return oldestPet;
        }
        public int Count
        {
            get { return this.items.Count; }
        }

        public string GetStatistics()
        {
            StringBuilder output = new StringBuilder();
            output.Append($"The clinic has the following patients:");
            foreach (Pet pet in this.items)
            {
                output.Append($"\nPet {pet.Name} with owner: {pet.Owner}");
               
                
            }
            string s = output.ToString();
            return s;
        }

    }
}
