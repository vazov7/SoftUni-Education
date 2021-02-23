using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            dog.Pop();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
            cat.Pop();

            FrenchBulldog fench = new FrenchBulldog();
            fench.DaysAfterBorn();
            fench.Bark();
            fench.Eat();
            fench.IsHaveBulhi = true;
            Console.WriteLine(fench.IsHaveBulhi);
            fench.Pop();
        }
    }
}
