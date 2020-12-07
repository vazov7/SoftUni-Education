using System;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console int 3 numbers
            int stepsNumber = int.Parse(Console.ReadLine());
            int dancersNumber = int.Parse(Console.ReadLine());
            int daysForLearning = int.Parse(Console.ReadLine());
            //calculate total of steps per day in %
            double numProcentOfDay = stepsNumber / daysForLearning;
            double stepsPerDay = Math.Ceiling((numProcentOfDay * 100) / stepsNumber);
            //calculate total % of steps per person
            double procentPerPerson = stepsPerDay / dancersNumber;
            //make verification if % of steps per day <=13% ><> o	"Yes, they will succeed in that goal! {процент стъпки които трябва да научи всеки един танцьор на ден}%."
            if (stepsPerDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {procentPerPerson:F2}%.");

            }
            else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {procentPerPerson:F2}% steps to be learned per day.");
            }
            //if total % per day is > 13% ><> o	"No, they will not succeed in that goal! Required {процент стъпки, които трябва да научи всеки един танцьор на ден}% steps to be learned per day."

        }
    }
}
