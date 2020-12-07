using System;

namespace _12._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            int dul = 0;
            dul = int.Parse(Console.ReadLine());
            Console.Write("Width: ");
            int sh = 0;
            sh = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int V = 0;
            V = int.Parse(Console.ReadLine());
            int sum = 0;
            sum = (dul + sh + V);
            Console.WriteLine($"Pyramid Volume: {sum:f2}");
            //ne sum q predal v judge otkazah se

        }
    }
}
