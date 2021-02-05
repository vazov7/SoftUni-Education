using System;

namespace BoxOfT
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            for (int i = 0; i < 5; i++)
            {

                box.Add(i);
                Console.WriteLine($"Add {i}");
            }
            Console.WriteLine($"Remove last nukmber in stack {box.Remove()}");
            for (int i = 0; i < 4; i++)
            {
            Console.WriteLine($"Number in box {box.Remove()}");
            }
        }
    }
}
