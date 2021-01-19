using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);


                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<decimal>{grade});
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }
            foreach (var key in studentGrades)
            {
                Console.Write($"{key.Key} -> ");
                foreach (var student in key.Value)
                {
                    Console.Write($"{student:f2} ");
                }
                Console.Write($"(avg: {key.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
