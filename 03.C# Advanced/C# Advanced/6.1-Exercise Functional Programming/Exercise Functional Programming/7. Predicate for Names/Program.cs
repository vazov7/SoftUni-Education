using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();
            Func<string,int, bool> func = (name,n) => name.Length <= n;

            names = names.Where(name => func(name,n)).ToList();

            Action<List<string>> print = names => Console.WriteLine(String.Join(Environment.NewLine, names));
            print(names);
        }
    }
}
