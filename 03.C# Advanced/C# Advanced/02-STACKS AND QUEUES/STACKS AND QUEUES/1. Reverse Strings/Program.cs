
using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> words = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                words.Push(input[i]);
            }
            while (words.Count > 0)
            {
                Console.Write(words.Pop());
            }
        }

    }
}
