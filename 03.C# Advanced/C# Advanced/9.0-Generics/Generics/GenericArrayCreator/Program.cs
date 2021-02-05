using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ArrayCreator<string> stringArray = new ArrayCreator<string>();
            string[] strings = stringArray.Create(5, "Pesho");
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
        }
    }
}
