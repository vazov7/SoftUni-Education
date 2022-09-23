using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = ("\\b(?<day>\\d{2})([-.\\/])(?<month>[A-Z][a-z]{2})\\1(?<year>\\d{4})\\b");
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, regex);


            foreach (Match item in matches)
            {

                //Console.WriteLine(item.Groups["day"].Value);
                Console.WriteLine($"Day: {item.Groups["day"].Value}, Month: {item.Groups["month"].Value}, Year: {item.Groups["year"].Value}");
            }

        }
    }
}
