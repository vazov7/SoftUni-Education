using System;
using System.Collections.Generic;


namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            stack.AddRange(new List<string>()
            {
                "12",
                "23",
                "34",
                "45",
                "56"
            }) ;
            foreach (var item in stack)
            {
                Console.WriteLine(item);

            }

            }
        }
    }


