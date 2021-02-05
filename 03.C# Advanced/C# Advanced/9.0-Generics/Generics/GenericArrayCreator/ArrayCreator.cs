using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator<T>
    {
       public T[] Create(int lenght, T item)
        {
            T[] array = new T[lenght];
            array[0] = item;
            return array;
        }
    
        
    }
}
