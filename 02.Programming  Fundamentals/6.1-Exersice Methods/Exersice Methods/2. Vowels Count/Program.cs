using System;
using System.Linq;

namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int vowelsCount = FindVowelsInWord(word);
            Console.WriteLine(vowelsCount);
        }
        static int FindVowelsInWord(string word)
        {
            int vowelsCount = 0;
            char[] everyLetter = word.ToCharArray();
            for (int i = 0; i < everyLetter.Length; i++)
            {
                switch (everyLetter[i])
                {
                    case 'a':
                        vowelsCount++;
                        break;
                    case 'e':
                        vowelsCount++;
                        break;
                    case 'i':
                        vowelsCount++;
                        break;
                    case 'o':
                        vowelsCount++;
                        break;
                    case 'u':
                        vowelsCount++;
                        break;
                    case 'y':
                        vowelsCount++;
                        break;
                }

            }
            return vowelsCount;
        }
    }
}
