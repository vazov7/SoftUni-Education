using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("kolko si durt");
                age = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("tolkova LI NE MOJESH DA NAPISHEHS ENDO CHISLO");

                try
                {
                    age = int.Parse(Console.ReadLine());

                }
                catch (Exception exsecond)
                {
                    Console.WriteLine(exsecond.Message);
                    Console.WriteLine(exsecond.GetType());
                    Console.WriteLine("chslo napishi be chpovek cghislo");
                    age = int.Parse(Console.ReadLine());
                }
               


            }
            Console.WriteLine($"{age} abe durt si");
        }
    }
}
