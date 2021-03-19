using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Gosho", "Whiskas");
            Animal dog = new Dog("Pesho", "Meat");
            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
