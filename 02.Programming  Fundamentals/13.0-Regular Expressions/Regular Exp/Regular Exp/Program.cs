using System;
using System.Text.RegularExpressions;

namespace Regular_Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)";
            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();
            var matches = regex.Matches(text);

            Console.WriteLine(string.Join(" ", matches));

        }
    }
}
