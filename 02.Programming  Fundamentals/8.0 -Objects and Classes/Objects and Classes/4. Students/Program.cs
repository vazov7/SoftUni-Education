using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string City{ get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> newStudents = new List<Students>();
            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "end")
            {
                string firstName = command[0];
                string lastName = command[1];
                string age = command[2];
                string city = command[3];

                Students students = new Students();

                students.FirstName = firstName;
                students.LastName = lastName;
                students.Age = age;
                students.City = city;

                newStudents.Add(students);

                command = Console.ReadLine().Split().ToList();
            }
            string finalCity = Console.ReadLine();
            List<Students> filtredStudents = newStudents.Where(n => n.City == finalCity).ToList();
            foreach (Students students in filtredStudents)
            {
                Console.WriteLine($"{students.FirstName} {students.LastName} is {students.Age} years old.");
            }
        }
    }
}
