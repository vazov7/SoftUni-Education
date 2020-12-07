using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _1._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> words = Console.ReadLine().Split().ToList();
           
            Random rnd = new Random();
            while(words.Count > 0)
            {
                int randomNumber = rnd.Next(0, words.Count - 1);

                
                    Console.WriteLine(words[randomNumber]);
                    words.RemoveAt(randomNumber);
                    
                
                
            }

        }
    }
}
