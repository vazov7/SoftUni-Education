using System;

namespace ConcatenteData
{
    class Program
    {
        static void Main(string[] args)
        {

            //read info ({firstname} {lastname} {age} {town}) from console.
            //: "You are <firstName> <lastName>, a <age>-years old person from <town>."
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            //write info in console
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");

        }
    }
}
