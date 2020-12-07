using System;

namespace AddressByAgeAndGender1
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from cosole age and gender
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            //if age and gender is m >= 16 ><> cw Mr.
            if (gender == 'm')
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else 
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            //if age and gender is f >=16 ><> cw ms. ><>< if
        }
    }
}
