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
            long totalPoints = 0;
            string pattern = @"(\d)";
            var match = Regex.Matches(text, pattern);
            foreach (Match item in match)
            {
                if (totalPoints == 0)
                {
                    totalPoints = int.Parse(item.Value);
                }
                else
                {
                    totalPoints *= int.Parse(item.Value);
                }
            }


            string emojiPattern = @"([::|**]{2})(?<text>[A-Z][a-z]{2,})(\1)";
            var validEmojis = Regex.Matches(text, emojiPattern);
            List<string> coolEmoji = new List<string>();
            int emojisCount = validEmojis.Count;
            foreach (Match emoji in validEmojis)
            {
                int validCount = 0;
                string validEmoji = emoji.Groups["text"].ToString();
                for (int i = 0; i < validEmoji.Length; i++)
                {
                    validCount += validEmoji[i];
                }
                if (validCount >= totalPoints)
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
