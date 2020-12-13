using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\*{1}|@{1})(?<tag>[A-Z][a-z]{2,})(\1):\s\[{1}(?<firstGroup>\w{1})\]\|\[(?<secondGroup>\w{1})\]\|\[(?<thirdGroup>\w{1})\]\|$";
            uint n = uint.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string tag = match.Groups[3].ToString();
                    uint firstGroup = (uint)char.Parse(match.Groups[4].ToString());
                    uint secondGroup = (uint)char.Parse(match.Groups[5].ToString());
                    uint thirdGroup = (uint)char.Parse(match.Groups[6].ToString());
                    Console.WriteLine($"{tag}: {firstGroup} {secondGroup} {thirdGroup}");


                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }




            }
        }
    }
}
