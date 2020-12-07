using System;

namespace _3._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintChars(firstChar, secondChar);
        }
        static void PrintChars(char firstchar, char secondChar)
        {
            if (firstchar < secondChar)
            {

                int count = 1;
                while (firstchar != secondChar)
                {
                    if (count == 1)
                    {
                        count++;

                    }
                    else
                    {

                        Console.Write(firstchar + " ");
                    }
                    firstchar++;
                }
            }
            else if (firstchar > secondChar)
            {
                
                int count = 1;
                while (firstchar != secondChar)
                {
                    if (count == 1)
                    {
                        count++;

                    }
                    else
                    {

                        Console.Write(secondChar + " ");
                    }
                    secondChar++;
                }
            }
        }
    }
}
