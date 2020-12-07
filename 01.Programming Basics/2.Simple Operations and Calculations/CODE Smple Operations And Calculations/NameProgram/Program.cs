using System;

namespace NameProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //read names and years from console and save them in variable
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());

            //write names and years to console in 3 ways

            //simple way
            Console.WriteLine("My full name is " + firstName + " " + secondName + " and im on " + age + " years old.");

            //string format {0}
            Console.WriteLine("2 My full name is {0} {1} and im on {2:F1} years old.", firstName, secondName, age);

            //string interpolation {variable}
            Console.WriteLine($"3 My full name is {firstName} {secondName} and im on {age:F1} years old.");
             
            //read name from console
            //Console.WriteLine("Enter Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter First Cat Name: ");
            //string catNameOne = Console.ReadLine();
            //Console.Write("Enter Second Cat Name: ");
            //string catNameTwo = Console.ReadLine();
            //Console.Write("Enter First Dog Name: ");
            //string dogNameOne = Console.ReadLine();
            //Console.Write("Enter Second dog Name: ");
            //string dogNameTwo = Console.ReadLine();


            //Console.WriteLine("My name is " + name);
            //Console.WriteLine("2 My name is {0} {1} {2}", name, catNameOne, dogNameOne);
            //Console.WriteLine($"My name is {name} {catNameOne} {catNameTwo}");
            //Console.WriteLine($"My name is {name} and i have two cats and two dogs.Name of first can is {catNameOne} ,name of second cat is {catNameTwo} ,Name of first dog is {dogNameOne} and second dog name is {dogNameTwo}.");

        }
    }
}
