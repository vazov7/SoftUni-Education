using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            FindTopNumber(number);
        }

        private static void FindTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                var currentNumber = i.ToString();
                bool isDivideForEight = false;
                bool isHaveOddNum = false;
                int sumOfDigits = 0;

                foreach (var c in currentNumber)
                {
                    int curr = (int)c;
                    sumOfDigits += curr;
                    if (curr % 2 == 1)
                    {
                        isHaveOddNum = true;
                    }
                }
                if (sumOfDigits % 8 == 0)
                {
                    isDivideForEight = true;
                }
                if (isHaveOddNum && isDivideForEight)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
