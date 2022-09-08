using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _7.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> strudensAndGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (strudensAndGrades.ContainsKey(name))
                {
                    strudensAndGrades[name].Add(grade);
                }
                else
                {
                    strudensAndGrades.Add(name, new List<double>());
                    strudensAndGrades[name].Add(grade); 
                }
                
            }

            foreach (var item in strudensAndGrades)
            {
                double avrg = strudensAndGrades[item.Key].Average();
                strudensAndGrades[item.Key][0] = avrg;
            }

            foreach (var item in strudensAndGrades)
            {
                if (strudensAndGrades[item.Key][0] < 4.50)
                {
                    strudensAndGrades.Remove(item.Key);
                }
            }
            //.OrderByDescending(x => x.Value[0])
            //John -> 5.00
            foreach (var item in strudensAndGrades.OrderByDescending(x => x.Value[0]))
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0]:f2}");
            }
            //IN judge the exercise is broken

        }
    }
}
