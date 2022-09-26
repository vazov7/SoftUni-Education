using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> rawPassword = new List<char>();
            string cmd = string.Empty;
            while ((cmd = Console.ReadLine()) != "Done")
            {
                List<string> command = cmd
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (command[0] == "TakeOdd")
                {


                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            rawPassword.Add(input[i]);

                        }
                    }
                    string password = string.Join("", rawPassword);
                    Console.WriteLine(password);
                }
                else if (command[0] == "Cut")
                {
                    rawPassword.RemoveRange(int.Parse(command[1]), int.Parse(command[2]));
                    string password = string.Join("", rawPassword);
                    Console.WriteLine(password);
                }
                else if (command[0] == "Substitute")
                {
                    string password = string.Join("",rawPassword);
                    if (password.Contains(command[1]))
                    {
                        string newstr = password.Replace(command[1], command[2]);
                        password = newstr;
                        rawPassword.Clear();
                        for (int i = 0; i < password.Length; i++)
                        {
                            rawPassword.Add((char)password[i]);
                        }
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            string password = string.Join("", rawPassword);
            ;
            Console.WriteLine($"Your password is: {password}");



        }
    }
}
