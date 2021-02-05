using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList newList = new GenericList();
            for (int i = 0; i < 10; i++)
            {
                newList.Add(i.ToString());
            }
        }
    }
}
