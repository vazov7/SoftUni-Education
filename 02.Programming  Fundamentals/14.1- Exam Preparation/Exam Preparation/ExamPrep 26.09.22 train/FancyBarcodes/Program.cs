using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@#+)(?<body>[A-Z][A-Za-z\d]{4,}[A-Z])(@#+)";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string productGroup = "00";
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string body = match.Groups["body"].ToString();
                    //int nums = match.Groups["body"].ToString().Select(Char.)
                    string rawGroup = string.Empty;
                    for (int v = 0; v < body.Length; v++)
                    {
                        if (Char.IsDigit(body[v]))
                            rawGroup += body[v];
                    }
                    if (rawGroup.Length > 0)
                        productGroup = rawGroup;

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
        
    }
}
