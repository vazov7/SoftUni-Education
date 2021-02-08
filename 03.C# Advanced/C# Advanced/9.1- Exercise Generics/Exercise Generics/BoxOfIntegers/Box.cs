using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfIntegers
{
    public class Box<T>
    {
        private List<T> strings = new List<T>();

        public void Add(T item)
        {
            this.strings.Add(item);

        }
        public void Print()
        {
            foreach (var item in strings)
            {
                item.ToString();
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

    }
}
