using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Store_Boxes
{
    public class Item
    {
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
    }
    public class Box
    {
        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public string ItemQuantity { get; set; }
        public string PricePerBox { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> 
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] == "end")
            {

                command = Console.ReadLine().Split().ToList();
            }
        }
    }
}
