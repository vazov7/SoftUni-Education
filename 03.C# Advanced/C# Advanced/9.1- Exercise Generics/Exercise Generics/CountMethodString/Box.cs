using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CountMethodString
{
    public class Box<T>
    {
        private List<string> items = new List<string>();
        private int comparerInputSum;
        int count = 0;
        public void AddComparer(T input)
        {
            int sum = 0;
            string comarer = input.ToString();
            for (int i = 0; i < comarer.Length; i++)
            {
                sum += comarer[i];
            }
            this.comparerInputSum = sum;
        }
        public void Add(T item)
        {
            this.items.Add(item.ToString());
        }

        public void CountAndPrint()
        {
            foreach (var item in items)
            {
                int sum = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    sum += item[i];
                }
                if (sum > this.comparerInputSum)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
