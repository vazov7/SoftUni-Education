using System;

namespace _6_Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine().ToLower();

            if (country == "england" || country == "usa")
            {
                Console.WriteLine("English");
            }
            else if (country == "spain" || country == "mexico" || country == "argentina")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
