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
                        try
                        {
                            list.Print();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                            throw;
                        }
                        break;
                    case "hasnext":
                        list.HasNext();
                        break;
                    case "printall":
                        foreach (var item in list)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }
            


        }
    }
}
