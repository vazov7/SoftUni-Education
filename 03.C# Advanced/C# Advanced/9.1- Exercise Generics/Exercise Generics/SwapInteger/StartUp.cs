using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwapInteger
{
    public class StartUp
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }
            List<int> indexer = Console.ReadLine().Split().Select(int.Parse).ToList();


            Swap(list, indexer);
        }
        public static void Swap<T>(List<T> list, List<int> indexers)
        {
            var firstIndex = list[indexers[0]];

            var temp = firstIndex;
            list[indexers[0]] = list[indexers[1]];
            list[indexers[1]] = temp;
            foreach (var item in list) 
            {
                string output = $"{item.GetType()}: {item}";
                Console.WriteLine(output);
                //Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
