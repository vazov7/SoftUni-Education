using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            long totalPoints = 1;
            string pattern = @"(\d)";
            var match = Regex.Matches(text, pattern);
            match.Select(m => m.Value)
                .Select(int.Parse)
                .ToList()
                .ForEach(x => totalPoints *= x);


            string emojiPattern = @"(:{2}|\*{2})[A-Z][a-z]{2,}(\1)";
            var validEmojis = Regex.Matches(text, emojiPattern);
            List<string> coolEmoji = new List<string>();
            int emojisCount = validEmojis.Count;
            foreach (Match emoji in validEmojis)
            {

                long coolIndex = emoji.Value
                    .Substring(2, emoji.Value.Length - 4)
                    .ToString()
                    .ToCharArray()
                    .Sum(x => (int)x);
                if (coolIndex >= totalPoints)
                {
                    coolEmoji.Add(emoji.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {totalPoints}");
            Console.WriteLine($"{emojisCount} emojis found in the text. The cool ones are:");
            if (coolEmoji.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, coolEmoji));

            }



        }
    }
}
