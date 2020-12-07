using System;

namespace _6._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                char firstChar = (char)('a' + i);
                for (int j = 0; j < num; j++)
                {
                    char secondChar = (char)('a' + j);
                    for (int k = 0; k < num; k++)
                    {
                        char thirdChar = (char)('a' + k);
                        Console.Write(firstChar);
                        Console.Write(secondChar);
                        Console.Write(thirdChar);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
