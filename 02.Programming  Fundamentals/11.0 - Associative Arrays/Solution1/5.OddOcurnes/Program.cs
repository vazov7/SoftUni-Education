using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.OddOcurnes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read list of strings(words) and make it to lower case
            List<string> input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(n => n.ToLower())
                .ToList();

            //count how much words repeats
            Dictionary<string,int> output = new Dictionary<string,int>();

            foreach (var item in input)
            {
                if (output.ContainsKey(item))
                {
                    output[item]++;
                }
                else
                {
                    output.Add(item, 1);
                }
            }
            //check if repeats is odd print it or ignore it
            foreach (var item in output)
            {
                if (item.Value % 2 == 1)
                {
                    Console.Write($" {item.Key}");
                }
            }
        }
    }
}
