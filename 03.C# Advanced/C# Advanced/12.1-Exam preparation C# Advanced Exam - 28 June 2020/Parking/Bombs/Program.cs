using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] daturaBomb = new int[] { 40, 0 };
            int[] chrryBomb = new int[] { 60, 0 };
            int[] smokeDecoyBomb = new int[] { 120, 0 };

            Queue<int> bombEffects = new Queue<int>();
            Stack<int> bombCases = new Stack<int>();

            List<int> effectInput = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            List<int> caseInput = Console.ReadLine().Split(", ").Select(int.Parse).ToList();


            for (int i = 0; i < caseInput.Count; i++)
            {
                bombCases.Push(caseInput[i]);
            }
            for (int i = 0; i < effectInput.Count; i++)
            {
                bombEffects.Enqueue(effectInput[i]);
            }



            while (!((daturaBomb[1] >= 3 && chrryBomb[1] >= 3 && smokeDecoyBomb[1] >= 3) || (bombEffects.Count <= 0) || (bombCases.Count <= 0)))
            {
                int bombEffect = bombEffects.Peek();
                int bombCase = bombCases.Peek();
                int sum = bombEffect + bombCase;
                if (sum == daturaBomb[0])
                {
                    daturaBomb[1]++;
                    bombEffects.Dequeue();
                    bombCases.Pop();
                }
                else if (sum == chrryBomb[0])
                {
                    chrryBomb[1]++;
                    bombEffects.Dequeue();
                    bombCases.Pop();
                }
                else if (sum == smokeDecoyBomb[0])
                {
                    smokeDecoyBomb[1]++;
                    bombEffects.Dequeue();
                    bombCases.Pop();
                }
                else
                {
                    int n = bombCases.Pop();
                    bombCases.Push(n - 5);
                }
            }
            bool isFullPouch = daturaBomb[1] >= 3 && chrryBomb[1] >= 3 && smokeDecoyBomb[1] >= 3;
            if (isFullPouch)
                Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
            else
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");

            if (!(bombEffects.Count <= 0))
            {
                Console.Write("Bomb Effects: ");
                Console.Write(string.Join(", ", bombEffects));
                Console.WriteLine();
            }
            else
                Console.WriteLine("Bomb Effects: empty");

            if (!(bombCases.Count <= 0))
            {
                Console.Write("Bomb Casings: ");
                Console.Write(string.Join(", ", bombCases));
                Console.WriteLine();
            }
            else
                Console.WriteLine("Bomb Casings: empty");



            Console.WriteLine($"Cherry Bombs: {chrryBomb[1]}");
            Console.WriteLine($"Datura Bombs: {daturaBomb[1]}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBomb[1]}");


        }
    }
}
