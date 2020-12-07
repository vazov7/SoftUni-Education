using System;

namespace NumberSequence
{
    class Program
    {        

        static void Main(string[] args)
        {
                       
            double maxNumber = int.MinValue;
            double minNumber = int.MaxValue;         
            while (true)
            {
                var loopNumber = Console.ReadLine();
                if (loopNumber == "END")
                    break;
                int num = int.Parse(loopNumber);
                if(num > maxNumber)
                {
                    maxNumber = num;
                } 
                if(num < minNumber)
                {
                    minNumber = num;
                }
                
            }
            Console.WriteLine("Max number: " + maxNumber);
            Console.WriteLine("Min number: " + minNumber);
        }
    }
}
