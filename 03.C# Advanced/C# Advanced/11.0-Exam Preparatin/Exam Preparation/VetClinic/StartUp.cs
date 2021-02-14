using System;

namespace VetClinic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Pet dog = new Pet("gosho", 3 , "vazov");

            Clinic clinic = new Clinic(20);
            //clinic.Add(dog);
            //Console.WriteLine(dog);
            //
            //Console.WriteLine(clinic.Remove("Pufa"));
            //Console.WriteLine(clinic.Remove("gosho"));
            //
            Pet cat = new Pet("Bella", 2, "Mia");
            Pet bunny = new Pet("Zak", 4, "Jon");
            clinic.Add(cat);
            clinic.Add(bunny);
            Pet pet = clinic.GetPet("Bella", "Mia");
            Console.WriteLine(pet); // Bella 2 (Mia)

            Pet oldestPet = clinic.GetOldestPet();
            Console.WriteLine(oldestPet); // Zak 4 (Jon)

            Console.WriteLine($"count is {clinic.Count}");
            Console.WriteLine(clinic.GetStatistics());

        }
    }
}
