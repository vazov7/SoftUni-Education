using System;
using System.Linq;

namespace _9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            while ( (command = Console.ReadLine()) != "END")
            {
                int number = int.Parse(command);

                int reverseNumber = ReverseNumber(number);
                if (number == reverseNumber)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }



        private static int ReverseNumber(int number)
        {

            char[] cArray = number.ToString().ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            int reverseNumbers = int.Parse(reverse);
            return reverseNumbers;
        }
    }
}
