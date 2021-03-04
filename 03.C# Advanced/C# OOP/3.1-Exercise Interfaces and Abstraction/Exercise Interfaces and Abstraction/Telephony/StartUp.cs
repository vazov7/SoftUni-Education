using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();
            List<string> inputNumbers= Console.ReadLine().Split().ToList();

            Queue<string> numbers = new Queue<string>();
            foreach (var item in inputNumbers)
            {
                numbers.Enqueue(item);
                
            }

            List<string> inputSites = Console.ReadLine().Split().ToList();

            Queue<string> sites = new Queue<string>();
            foreach (var item in inputSites)
            {
                sites.Enqueue(item);
            }

            foreach (var item in numbers)
            {
                if (item.Length == 7)
                {
                    Console.WriteLine(stationaryPhone.CallOtherPhones(item)); ;
                }
                else if (item.Length == 10)
                {
                    Console.WriteLine(smartphone.CallOtherPhones(item));
                }
            }

            foreach (var item in sites)
            {
                Console.WriteLine(smartphone.BrowseInWorldWideWeb(item));
            }



        }
    }
}
