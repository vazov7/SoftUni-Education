using System;
using System.Text;

namespace _6._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string middleStringEven = GetMiddleStringFromEvenText(text);
            string middleStringOdd = GetMiddleStringFromOddText(text);
            if (text.Length %2 ==0)
            {
                Console.WriteLine(middleStringEven);
            }
            else
            {
                Console.WriteLine(middleStringOdd);
            }
        }

        private static string GetMiddleStringFromOddText(string text)
        {
            int index = text.Length / 2;
            string chars = text.Substring(index , 1);
                return chars;
        }

        private static string GetMiddleStringFromEvenText(string text)
        {
            int stringLenght = text.Length;
            string firstStr = string.Empty;
            string secondStr = string.Empty;
            if (stringLenght % 2 == 0)
            {
                int firstSt = text.Length / 2;
                int secondSt = text.Length / 2 + 1;
                firstStr = text[firstSt - 1].ToString();
                secondStr = text[secondSt - 1].ToString();
            }
            StringBuilder output = new StringBuilder();
            //string output = string.Join(firstStr, secondStr);
            return output.Append(firstStr).Append(secondStr).ToString();
        }
    }
}
