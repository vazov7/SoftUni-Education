using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int sitsPlaces = rows * columns;
            double price = 0.0;
            switch (typeOfProjection)
            {
                case "Premiere":
                    price = 12.00;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00;
                    break;                
            }
            double totalPrice = price * sitsPlaces;
            Console.WriteLine($"{totalPrice:F2} leva");

        }
    }
}
