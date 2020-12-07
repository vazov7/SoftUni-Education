using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().ToLower().Split().ToList();

            while (command[0] != "end")
            {
                if (command[0] == "delete")
                {
                    numbers.RemoveAll(n=> n == int.Parse(command[1]));
                }
                else if (command[0] == "insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
            command = Console.ReadLine().ToLower().Split().ToList();
            }
            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
