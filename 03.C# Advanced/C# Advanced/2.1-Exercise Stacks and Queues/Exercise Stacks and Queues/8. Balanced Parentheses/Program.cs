using System;
using System.Collections;
using System.Collections.Generic;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isbalanced = true;

            //  {[()]}
            foreach (var item in input)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    stack.Push(item);
                }
                else if (item == ')' || item == ']' || item == '}')
                {
                    if (stack.Peek() == '(' && ')' == item)
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '{' && '}' == item)
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '[' && ']' == item)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        isbalanced = false;
                        break;
                    }
                }
            }
            if (isbalanced)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}

