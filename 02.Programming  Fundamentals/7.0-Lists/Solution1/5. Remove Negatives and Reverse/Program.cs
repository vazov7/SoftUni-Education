using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> theList = Console.ReadLine().Split().Select(int.Parse).Where(n => n > 0).Reverse().ToList();
            if (theList.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {

            Console.WriteLine(string.Join(" ", theList));
            }
        }
    }
}
// 100 % Jugdge YEp