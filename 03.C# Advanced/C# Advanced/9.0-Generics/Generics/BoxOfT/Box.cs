using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        Stack<T> box = new Stack<T>();
        public void Add(T element)
        {
            box.Push(element);
        }
        public T Remove()
        {
            return box.Pop();
        }
        public int Count
        {
            get { return this.box.Count; } 
            
        }
    }
}
