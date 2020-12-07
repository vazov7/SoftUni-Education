using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int secondChar = int.Parse(Console.ReadLine());


            for (int i = firstChar; i <= secondChar; i++)
            {
                char charr = (char)i;
                Console.Write(charr + " ");
                 

            }

        }
    }
}
