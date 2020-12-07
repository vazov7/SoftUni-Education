using System;
using System.Collections.Generic;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (!letters.ContainsKey(letter))
                    {
                        letters.Add(letter, 0);
                    }

                    letters[letter]++;
                }
            }

            foreach (var c in letters)
            {
                char currentKey = c.Key;
                int cuttentValue = c.Value;
                Console.WriteLine($"{currentKey} -> {cuttentValue}");
            }
        }
    }
}
