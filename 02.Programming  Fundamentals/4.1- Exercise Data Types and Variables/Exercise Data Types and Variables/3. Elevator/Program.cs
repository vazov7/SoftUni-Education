using System;

namespace _3._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peoples = int.Parse(Console.ReadLine());
            int peoplesCapacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)peoples / peoplesCapacity);
            Console.WriteLine( courses);
        }
    }
}
