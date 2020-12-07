using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<string> commands = Console.ReadLine().Split().ToList();
            while (commands[0] != "end")
            {
                string firstMessage = commands[1];
                switch (commands[0])
                {
                    case "Chat":
                        messages.Add(firstMessage);
                        break;
                    case "Delete":
                        messages.Remove(firstMessage);
                        break;
                    case "Edit":
                        string secondMessage = commands[2];
                        int index = messages.FindIndex(x => x == firstMessage);
                        messages[index] = secondMessage;
                        break;
                    case "Pin":
                        int index1 = messages.FindIndex(x => x == firstMessage);
                        string word = messages[index1];
                        messages.Remove(firstMessage);
                        messages.Add(word);
                        break;
                    case "Spam":
                        for (int i = 1; i < commands.Count; i++)
                        {
                            messages.Add(commands[i]);
                        }
                        break;
                }

                commands = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(Environment.NewLine, messages));
        }
    }
}
