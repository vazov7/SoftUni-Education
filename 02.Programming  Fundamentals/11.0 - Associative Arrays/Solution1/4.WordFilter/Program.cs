using System;
using System.Linq;

namespace _4.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(s => s.Length % 2 == 0)
                .ToArray();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
