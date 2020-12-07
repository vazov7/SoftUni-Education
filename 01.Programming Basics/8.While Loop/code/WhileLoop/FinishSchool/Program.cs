using System;

namespace FinishSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double yearsGate = 0.0;
            int counter = 1;            
            while (counter <= 12)
            {

                double num = double.Parse(Console.ReadLine());
                if (num >= 4)
                {
                    yearsGate += num;
                    counter++;
                }

            }
            double averageGate = yearsGate / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGate:F2}");
        }
    }
}

