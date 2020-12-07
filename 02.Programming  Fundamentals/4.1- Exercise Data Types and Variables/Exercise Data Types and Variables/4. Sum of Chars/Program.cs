using System;

namespace _4._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int totalSum = 0;         

           for (int i = 0; i < lines; i++)
           {
               int chars = (int)char.Parse(Console.ReadLine());
                totalSum += chars;               
           }
               Console.WriteLine($"The sum equals: { totalSum}");
        }
    }
}
