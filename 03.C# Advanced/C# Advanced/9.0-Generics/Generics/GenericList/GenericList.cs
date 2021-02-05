using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    class GenericList<T>
    {
        public void Add(T element)
        {
            List<T> list = new List<T>();
            list.Add(element);
            Console.WriteLine($"Added: {element} Type : {element.GetType()}");

        }
    }
}
