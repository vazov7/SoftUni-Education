using System;
using System.Collections.Generic;

namespace TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trafficCars = int.Parse(Console.ReadLine());
            string input;
            Queue<string> queue = new Queue<string>();
            int count = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    
                    for (int i = 0; i < trafficCars; i++)
                    {
                        if (queue.Count ==0 )
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                    }

                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
