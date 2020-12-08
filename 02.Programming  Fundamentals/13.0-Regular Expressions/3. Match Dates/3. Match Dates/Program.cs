using System;
using System.Text.RegularExpressions;



namespace _3._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<mounth>[A-Z]\w{2})\1(?<year>\d{4})";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            var matches = regex.Matches(input);
           

            foreach (Match date in matches)
            {
                var day = date.Groups["day"];
                var mounth = date.Groups["mounth"];
                var year = date.Groups["year"];

                Console.WriteLine($"Day: {day}, Month: {mounth}, Year: {year}");
            }

        }
    }
}
