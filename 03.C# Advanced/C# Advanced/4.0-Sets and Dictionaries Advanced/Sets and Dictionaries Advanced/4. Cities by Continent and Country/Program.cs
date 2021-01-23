using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> towns = new Dictionary<string, Dictionary<string, List<string>>>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string continent = input[0];
                string country= input[1];
                string city = input[2];

                if (towns.ContainsKey(continent))
                {
                    if (towns[continent].ContainsKey(country))
                    {
                        towns[continent][country].Add(city);
                    }
                    else
                    {
                        towns[continent].Add(country, new List<string>{city});
                    }
                }
                else
                {
                    towns.Add(continent, new Dictionary<string, List<string>>());
                    towns[continent].Add(country, new List<string> { city });
                }

            }

            foreach (var continent in towns)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }

        }
    }
}
