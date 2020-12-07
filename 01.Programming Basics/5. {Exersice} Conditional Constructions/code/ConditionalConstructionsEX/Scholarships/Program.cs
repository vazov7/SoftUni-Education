using System;

namespace Scholarships
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console Income in BGN - доход в лева , Average success - среден успех , Minimum wage - минимална работна заплата.
            double incomeInBGN = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minumunWage = double.Parse(Console.ReadLine());
            //calculate social scholarship >=4.50><> . 35% of minimun wage
            double socialScholarship = 0;
            double successScholarship = 0;
            //calculate success scholarship >=5.50><> average success * 25
            
            // if income > minumun Wage ><> "You cannot get a scholarship!"
            // if average success < 5.50 ><> "You cannot get a scholarship!"
            //if income < minimun wage && average success >=  4.50 ><> "You get a Social scholarship {стойност на стипендия} BGN"
            // if average success >= 5.50 ><> "You get a scholarship for excellent results {стойност на стипендията} BGN"
            // if success > social scholarship ><> "You get a scholarship for excellent results {стойност на стипендията} BGN"
            // if social > success scholarship ><> "You get a Social scholarship {стойност на стипендия} BGN"
            if (incomeInBGN < minumunWage)
            {
                if (averageSuccess >= 5.50)
                {
                    successScholarship = Math.Floor(averageSuccess * 25);
                }
                 if (averageSuccess >= 4.50)
                {
                    socialScholarship = Math.Floor(0.35 * minumunWage);
                }
                if (successScholarship > socialScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {successScholarship} BGN");
                }
                else //if (socialScholarship > successScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
            }
            else
            {
                if(averageSuccess >= 5.50)
                {
                    successScholarship = averageSuccess * 25;
                    Console.WriteLine($"You get a scholarship for excellent results {successScholarship} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
        }
    }
}
