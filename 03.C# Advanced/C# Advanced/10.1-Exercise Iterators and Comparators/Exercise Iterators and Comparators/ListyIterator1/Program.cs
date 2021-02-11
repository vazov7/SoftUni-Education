using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterators
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().Skip(1).ToList(); ;
            ListyIterator<string> list = new ListyIterator<string>(input);

            string commands;
            while ((commands = Console.ReadLine().ToLower()) != "end")
            {
                switch (commands)
                {
                    case "move":
                        list.Move();
                        break;
                    case "print":
                        list.Print();
                        break;
                    case "hasnext":
                        list.HasNext();
                        break;
                    default:
                        break;
                }
            }
            


        }
    }
}
