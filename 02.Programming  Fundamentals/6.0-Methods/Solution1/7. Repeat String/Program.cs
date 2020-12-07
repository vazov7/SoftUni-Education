using System;
using System.Text;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string newText = ReverseText(text, count);
            Console.WriteLine(newText);
        }
        static string ReverseText(string text, int count)
        {
            StringBuilder newText = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                newText.Append(text);
            }
            return newText.ToString();
        }
    }
}
