using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = new List<string>();
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                commands = Console.ReadLine().Split().ToList();

                if (commands[0] == "register")
                {
                    if (users.ContainsKey(commands[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[commands[1]]}");
                        
                    }
                    else
                    {
                        users.Add(commands[1], commands[2]);
                        Console.WriteLine($"{commands[1]} registered {commands[2]} successfully");
                    }
                }
                else if (commands[0] == "unregister")
                {
                    if (!users.ContainsKey(commands[1]))
                    {
                        Console.WriteLine($"ERROR: user {commands[1]} not found");
                       
                    }
                    else
                    {
                        users.Remove(commands[1]);
                        Console.WriteLine($"{commands[1]} unregistered successfully");
                    }
                }   

            }
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
