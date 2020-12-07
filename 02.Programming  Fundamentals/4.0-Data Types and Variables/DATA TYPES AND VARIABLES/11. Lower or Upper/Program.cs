using System;

namespace _11._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());


            int firstCharInt = (int)firstChar;


            if (firstCharInt >= 65 && firstCharInt <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (firstCharInt >= 97 && firstCharInt <= 122)
            {
                Console.WriteLine("lower-case");
            }

        }
    }
}
