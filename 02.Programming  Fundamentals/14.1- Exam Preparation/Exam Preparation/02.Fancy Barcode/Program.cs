using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Fancy_Barcode
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@\#+\b)(?<body>[A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)";

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string body = match.Value;

                    string temp = string.Empty;

                    for (int j = 0; j < body.Length; j++)
                    {
                        if (Char.IsDigit(body[j]))
                        {
                            temp += body[j];
                        }
                    }

                    if (temp == "")
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {

                        Console.WriteLine($"Product group: {temp}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
