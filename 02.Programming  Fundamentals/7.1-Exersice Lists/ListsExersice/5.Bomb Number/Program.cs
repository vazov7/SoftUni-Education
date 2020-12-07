﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int itemToKill = bombArr[0];
            int rangeToKill = bombArr[1];
            int index = 0;

            while (numList.Contains(itemToKill))
            {
                index = numList.IndexOf(itemToKill);

                int leftRange = rangeToKill;
                int rightRange = rangeToKill;

                if (index - leftRange < 0) // тук ограничавам обсега на изтриване да не излиза извън индексите на колекцията
                {
                    leftRange = index;
                }

                if (index + rightRange >= numList.Count) // тук ограничавам обсега на изтриване да не излиза извън индексите на колекцията
                {
                    rightRange = numList.Count - index - 1;
                }

                numList.RemoveRange(index - leftRange, leftRange + rightRange + 1);
            }

            Console.WriteLine(numList.Sum());
        }
    }
}