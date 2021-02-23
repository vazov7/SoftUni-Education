using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Dog : Animal
    {
        public bool IsHaveBulhi { get; set; }
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }
}
