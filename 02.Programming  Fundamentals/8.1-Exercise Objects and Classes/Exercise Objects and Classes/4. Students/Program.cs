using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> listStudens = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                Student student = new Student(input[0], input[1], double.Parse(input[2]));
                listStudens.Add(student);
            }
            listStudens = listStudens.OrderByDescending(a => a.Grade).ToList();
    
            Console.WriteLine(string.Join(Environment.NewLine, listStudens));
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public double Grade{ get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}"; 
        }
    }
}
