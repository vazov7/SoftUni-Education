using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList rando = new RandomList();
            rando.Add("Pnnnneshkata");
            rando.Add("Peshkasdfata");
            rando.Add("Peshkatasdfas");
            rando.Add("Grisdhas");
            rando.Add("Peshkajklkghta");
            rando.Add("Peshkcxvccata");

            Console.WriteLine(   rando.RandomString()) ;
        }
    }
}
