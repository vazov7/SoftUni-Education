using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string doer = Console.ReadLine();

            while (doer != "Done")
            {
                List<string> commands = doer.Split().ToList();
                string command = commands[0];
                if (command== "TakeOdd")
                {
                    input = TakeOddLetters(input);
                    Console.WriteLine(input);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(commands[1]);
                    int lenght = int.Parse(commands[2]);
                    string newString = input.Remove(index, lenght);
                    input = newString;
                    Console.WriteLine(input);

                }
                else if (command == "Substitute")
                {
                    string substring = commands[1];
                    string substitute= commands[2];
                    if (input.Contains(substring))
                    {
                        string newString = input.Replace(substring, substitute);
                        input = newString;
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                doer = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {input}");
        }
        static string TakeOddLetters(string input)
        {
            StringBuilder oddString = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 1)
                {
                    oddString.Append(input[i]);
                }
            }
            string result = oddString.ToString();
            return result;
        }
    }
}
