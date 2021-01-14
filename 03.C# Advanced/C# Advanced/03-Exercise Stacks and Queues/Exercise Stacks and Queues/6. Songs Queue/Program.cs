using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstSongs = Console.ReadLine().Split(", ").ToList();
            Queue<string> songs = new Queue<string>(firstSongs);
            while (songs.Count >= 0)
            {
                List<string> commands = Console.ReadLine().Split(" ", 2).ToList();
                string command = commands[0];
                if (command == "Play")
                {
                    songs.Dequeue();
                    if (songs.Count == 0 )
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                }
                else if (command == "Add")
                {
                    if (songs.Contains(commands[1]))
                    {
                        Console.WriteLine($"{commands[1]} is already contained!");
                    }
                    else 
                    {
                    songs.Enqueue(commands[1]);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs ));
                }

            }
            
        }
    }
}
