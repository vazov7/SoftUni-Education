using System;

namespace BoxOfGenerics
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> strings = new Box<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                strings.Add(input);
            }
            strings.Print();
        }
    }
}
