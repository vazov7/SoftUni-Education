using System;

namespace BankBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int contributions = int.Parse(Console.ReadLine());
            
            double count = 0;
            double balance = 0.0;
            double totalMoney = 0.0;
            while (count < contributions)
            {
                balance = double.Parse(Console.ReadLine());
                if (balance < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }                                                                   
                Console.WriteLine($"Increase: {balance:F2}");
                count++;
                totalMoney += balance;
            }
            Console.WriteLine("Total: " + totalMoney);

        }
    }
}
