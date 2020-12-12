using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();
            string cmd = Console.ReadLine();
            while (cmd != "Generate")
            {
                List<string> commands = cmd.Split(">>>").ToList();
                string command = commands[0];
                if (command == "Contains")
                {
                    string substring = commands[1];
                    if (rawKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }

                }
                else if (command == "Flip")
                {
                    string upOrLow = commands[1];
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);

                    if (upOrLow == "Upper")
                    {
                        StringBuilder newKey = new StringBuilder();
                        for (int i = 0; i < rawKey.Length; i++)
                        {
                            if (i >= startIndex && i < endIndex)
                            {
                                string abv = rawKey[i].ToString();
                                abv = abv.ToUpper();
                                newKey.Append(abv);
                            }
                            else
                            {
                                newKey.Append(rawKey[i]);
                            }
                        }
                        rawKey = newKey.ToString();
                        Console.WriteLine(rawKey);

                    }
                    else if (upOrLow == "Lower")
                    {
                        StringBuilder newKey = new StringBuilder();
                        for (int i = 0; i < rawKey.Length; i++)
                        {
                            if (i >= startIndex && i < endIndex)
                            {
                                string abv = rawKey[i].ToString();
                                abv = abv.ToLower();
                                newKey.Append(abv);
                            }
                            else
                            {
                                newKey.Append(rawKey[i]);
                            }
                        }
                        rawKey = newKey.ToString();
                        Console.WriteLine(rawKey);

                    }

                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    string newKey = rawKey.Remove(startIndex +1  , endIndex - 2 );
                    rawKey = newKey;
                    Console.WriteLine(rawKey);

                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
