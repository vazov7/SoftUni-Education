using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _2._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[+]359([ |-])2(\1)222(\1)2222\b";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            var matches = regex.Matches(input);


            var matchedPhones = matches.Select(a => a.Value.Trim());

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
