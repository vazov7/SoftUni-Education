using System;

namespace GreatingByName
{
    class Program
    {
        static void Main(string[] args)
        {
            //read name from console
            string name = Console.ReadLine();

            //write name to console in "Hello, <name>!"
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
