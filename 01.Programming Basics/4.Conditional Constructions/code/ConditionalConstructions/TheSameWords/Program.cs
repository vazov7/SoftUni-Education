using System;

namespace TheSameWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            string flowFirstWord = firstWord.ToLower();
            string flowSecondWord = secondWord.ToLower();
            if (flowFirstWord == flowSecondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
