using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string>  input = Console.ReadLine().Split().ToList();
                foreach (var item in input)
                {
                elements.Add(item);

                }
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
