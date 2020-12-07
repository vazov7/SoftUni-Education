using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            if (comand == "int")
            {
                MaxOfInt();
            }
            else if (comand == "char")
            {
                MaxOfChar();
            }
            else if (comand == "string")
            {
                MaxOfString();
            }
        }
        static void MaxOfInt()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(firstNum, secondNum));
        }
        static void MaxOfChar()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char biggestChar = Convert.ToChar(Math.Max(firstChar, secondChar));
            Console.WriteLine(biggestChar);
        }
        static void MaxOfString()
        {
            //if (str1.CompareTo(str2)>=0)
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            if (firstString.CompareTo(secondString)>= 0)
            {

            Console.WriteLine(firstString);
            }
            else
            {
                Console.WriteLine(secondString);
            }
        }
    }
}
