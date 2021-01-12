using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> childrend = Console.ReadLine().Split().ToList();
            int n = int.Parse(Console.ReadLine());
            Queue<string> potaotesQueue = new Queue<string>(childrend);
            int count = 0;

            while (potaotesQueue.Count > 1)
            {
                count++;
                string kid = potaotesQueue.Dequeue();
                if (count == n)
                {
                    count = 0;
                    Console.WriteLine("Removed " + kid);
                }
                else
                {
                    potaotesQueue.Enqueue(kid);
                }
            }

            Console.WriteLine("Last is " + potaotesQueue.Dequeue());
        }
    }
}
