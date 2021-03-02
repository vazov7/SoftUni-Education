using System;
using System.Collections.Generic;
using System.Text;

namespace тест
{
    class Kitchen
    {
        public List<string> machines = new List<string>();
        public void OrderAMeal(string mealName)
        {
            Console.WriteLine($"Ordered meal {mealName}");
        }
        public void AddProdict(string productName)
        {
            Console.WriteLine($"add product {productName}");
        }
        public void CalculateCost()
        {
            Console.WriteLine("Cost is too much");
        }
        public void ListOfMachinary()
        {
            foreach (var item in machines)
            {
                Console.WriteLine(item);
            }
        }
    }
}
