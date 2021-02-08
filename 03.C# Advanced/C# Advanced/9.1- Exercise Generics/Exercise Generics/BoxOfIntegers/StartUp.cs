using System;

namespace BoxOfIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> strings = new Box<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                strings.Add(input);
            }
            strings.Print();
        }
    }
}
