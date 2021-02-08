using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwap
{
    public class StartUp
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }
            List<int> indexer = Console.ReadLine().Split().Select(int.Parse).ToList();


            Swap(list, indexer);
        }
       public static void Swap<T>(List<T> list,List<int> indexers)
        {
            var firstIndex = list[indexers[0]];

            var temp = firstIndex;
            list[indexers[0]] = list[indexers[1]];
            list[indexers[1]] = temp;
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        } 
    }
}
