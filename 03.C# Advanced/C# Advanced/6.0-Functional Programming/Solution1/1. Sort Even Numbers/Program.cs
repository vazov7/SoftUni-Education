using System;
using System.Linq;

namespace _1._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Where(n => int.Parse(n) % 2 == 0).Select(int.Parse).OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", numbers));
        } 
    }
}
