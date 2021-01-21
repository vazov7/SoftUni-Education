using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(" -> ").ToList();
                string color = input[0];
                List<string> inputClothes = input[1].Split(",").ToList();

                for (int j = 0; j < inputClothes.Count; j++)
                {
                    string item = inputClothes[j];

                    if (clothes.ContainsKey(color))
                    {
                        if (clothes[color].ContainsKey(item))
                        {
                            clothes[color][item]++;
                        }
                        else
                        {
                            clothes[color].Add(item, 1);
                        }
                    }
                    else
                    {
                        clothes.Add(color, new Dictionary<string, int>());
                        clothes[color].Add(item, 1);
                    }

                }

            }

            string[] find = Console.ReadLine().Split();
            string findColor = find[0];
            string findItem = find[1];

            foreach (var colorIn in clothes)
            {
                Console.WriteLine($"{colorIn.Key} clothes:");
                foreach (var item in colorIn.Value)
                {
                    if (findColor == colorIn.Key && findItem == item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }




        }
    }
}
