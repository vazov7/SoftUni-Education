using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int NameMinLenght = 1;
        private const int NameMaxLenght = 5;
        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (value.Length  < NameMinLenght || value.Length > NameMaxLenght)
                {
                    throw new ArgumentException($"Pizza name should be between {NameMinLenght} and {NameMaxLenght} symbols.");
                }
            }
        }
    }
}
