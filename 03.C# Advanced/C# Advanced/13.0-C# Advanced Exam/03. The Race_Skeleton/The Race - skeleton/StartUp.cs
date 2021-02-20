using System;

namespace TheRace
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Race race = new Race("Indianapolis 500", 10);

            Car car1 = new Car("ferrari", 150);
            Car car2 = new Car("lambo", 170);

            Racer racer1 = new Racer("Stephen", 40, "Bulgaria", car1);


            Console.WriteLine(racer1);
            race.Add(racer1);
            race.Remove("Vin Benzin");

            Racer racer2 = new Racer("Mark", 34, "UK", car2);

            race.Add(racer2);

            Racer oldestRacer = race.GetOldestRacer();
            Racer racerStephen = race.GetRacer("Stephen");

            Racer fastestRacer = race.GetFastestRacer();
            Console.WriteLine(oldestRacer); //Racer: Stephen, 40 (Bulgaria)
            Console.WriteLine(racerStephen); //Racer: Stephen, 40 (Bulgaria)
            Console.WriteLine(fastestRacer); // Racer: Mark, 34 (UK)
            Console.WriteLine(race.Count); //2

            Console.WriteLine(race.Report());

        }
    }
}
