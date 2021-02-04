using System;

namespace DefiningClasses
{
   public  class StartUp
    {
        static void Main(string[] args)
        {
            Person first = new Person();
            first.Age = 20;
            first.Name = "Pesho";

            Person second = new Person()
            {
                Age = 18,
                Name = "Gosho"
            };

            Person third = new Person() 
            {
                Age = 43,
                Name = "Stamat"
            };

        }
    }
}
