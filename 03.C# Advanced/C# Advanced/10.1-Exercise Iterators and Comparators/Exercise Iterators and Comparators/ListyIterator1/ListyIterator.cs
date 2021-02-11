using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterators
{
    public class ListyIterator<T>
    {
        private List<T> list;
        private int currnetItem = 0;
        public ListyIterator(List<T> list)
        {
            this.list = list;
        }
        public ListyIterator(params T[] items)
        {
            this.list = items.ToList();
        }
        public bool HasNext()
        {
            if (this.currnetItem + 1 <= this.list.Count- 1)
            {
                Console.WriteLine("True");
                return true;
            }
            Console.WriteLine("False");
            return false;
        }
        public void Print()
        {
            if (this.list.Any())
            {
                Console.WriteLine($"{this.list[this.currnetItem]}");
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

        }


        public bool Move()
        {
            if (this.currnetItem < this.list.Count - 1)
            {
                this.currnetItem++;
                Console.WriteLine("True");
                return true;
            }
            Console.WriteLine("False");
            return false;
        }


    }
}
