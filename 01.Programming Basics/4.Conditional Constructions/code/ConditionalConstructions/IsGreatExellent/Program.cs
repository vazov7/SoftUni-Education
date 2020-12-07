using System;

namespace IsGreatExellent
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console varable and save them
            double grade = double.Parse(Console.ReadLine());
            double lowestExcellentGrade = 5.5;
            bool isGradeExcellent = grade >= lowestExcellentGrade;
            //make the check
            if (isGradeExcellent)
            {
                Console.WriteLine("Excellent!");
            }

            //true or false
            //write to console
        }
    }
}
