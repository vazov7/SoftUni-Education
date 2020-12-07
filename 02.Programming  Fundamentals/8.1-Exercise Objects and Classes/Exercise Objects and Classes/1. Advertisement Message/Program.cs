using System;
using System.Collections.Generic;

namespace _1._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> phrases = new List<string>()  { "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product."  };

            List<string> events = new List<string>()  { "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!" };

            List<string> authors = new List<string>() { "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva" };

            List<string> city = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                string firstMessage = phrases[rnd.Next(0, phrases.Count)];
                string secondMessage = events[rnd.Next(0, events.Count)];
                string thirdMessage = city[rnd.Next(0, city.Count)];
                string quadMessage = authors[rnd.Next(0, authors.Count)];
                Console.WriteLine($"{firstMessage} {secondMessage} {thirdMessage} – {quadMessage}.");
            }
        }
    }
}
