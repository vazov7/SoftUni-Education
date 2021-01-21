using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nAndm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nAndm[0];
            int m = nAndm[1];
            List<int> firstGroup = new List<int>();
            List<int> secondGroup = new List<int>();
            List<int> totalNumbers = new List<int>();
            int count = 0;




            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstGroup.Add(number);
            }
            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondGroup.Add(number);
            }
            //if (firstGroup.Count > secondGroup.Count)
            //{
            //    count = secondGroup.Count;
            //    for (int i = 0; i < (count); i++)
            //    {
            //        if (firstGroup.Contains(secondGroup[i]))
            //        {
            //            totalNumbers.Add(secondGroup[i]);
            //        }
            //    }
            //}
            //else
            //{
                for (int i = 0; i < n; i++)
                {
                    if (secondGroup.Contains(firstGroup[i]))
                    {
                        totalNumbers.Add(firstGroup[i]);
                    }
                }
            //}
          //  List<int> output = secondGroup.Where(x => firstGroup.Contains(x)).ToList();
            
            Console.WriteLine(string.Join(" ", totalNumbers));

        }
    }
}
