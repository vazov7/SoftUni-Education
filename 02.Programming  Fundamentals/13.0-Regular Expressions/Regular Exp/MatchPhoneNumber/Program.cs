using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = ("\\+359([- ])2\\1(\\d{3})\\1(\\d{4})\\b");
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, regex);

            Console.WriteLine(string.Join(", ",matches.Cast<Match>()
                .Select(a=> a.Value.Trim())
                .ToList()));
            
        }
    }
}
