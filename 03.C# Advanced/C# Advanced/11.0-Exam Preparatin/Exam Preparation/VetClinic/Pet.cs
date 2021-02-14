using System;
using System.Collections.Generic;
using System.Text;

namespace VetClinic
{
    public class Pet
    {
        //Name: string
        //Age: int
        //Owner: string
        public string Name ;
        public int Age;
        public string Owner;
        public Pet(string name, int age, string owner)
        {
            this.Name = name;
            this.Age = age;
            this.Owner = owner;

        }
        public override string ToString()
        {
            return $"Name: {this.Name} Age: {this.Age} Owner: {this.Owner}";
        }
    } 
}
