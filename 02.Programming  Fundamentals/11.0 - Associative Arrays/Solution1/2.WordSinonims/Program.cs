using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.WordSinonims
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> counts = new Dictionary<string, List<string>>();

            for (int i = 0; i < lines; i++)
            {
                string word = Console.ReadLine();   
                string sinonim = Console.ReadLine();

                if (counts.ContainsKey(word))
                {
                    counts[word].Add(sinonim);
                }
                else
                {
                    counts.Add(word, new List<string>());
                    counts[word].Add(sinonim);
                }
            }

            foreach (var count in counts)
            {
                
                Console.WriteLine($"{count.Key} - " + String.Join(", ", count.Value));
            }
        }
    }
}
