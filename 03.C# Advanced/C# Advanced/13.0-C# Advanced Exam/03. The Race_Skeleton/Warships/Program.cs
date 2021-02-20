using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> plates = new Queue<int>();
            //LinkedList<int> plates = new LinkedList<int>();
            List<int> listplate = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            foreach (var item in listplate)
            {
                plates.Enqueue(item);
            }
            Stack<int> warriorsPower = new Stack<int>();

            for (int i = 1; i <= n; i++)
            {

                if (plates.Count == 0)
                {
                    break;
                }
                List<int> listWarriors = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                foreach (var item in listWarriors)
                    warriorsPower.Push(item);
                if (i == 3)
                {
                    int a = int.Parse(Console.ReadLine());
                    plates.Enqueue(a);
                }

                //if (plates.Count <= 0 || warriorsPower.Count <= 0)
                //{
                //    break;
                //}



                //ATTACKS

                int temp = warriorsPower.Count;
                while(warriorsPower.Count != 0)
                {

                    if (warriorsPower.Peek() > plates.Peek())
                    {
                        int c = warriorsPower.Pop() - plates.Dequeue();
                        warriorsPower.Push(c);
                        if (plates.Count == 0)
                        {
                            break;
                        }
                    }
                    else if (warriorsPower.Peek() < plates.Peek())
                    {
                        List<int> operators = plates.ToList();
                        //int c = warriorsPower.Pop() - plates.Dequeue();
                        int c = operators[0] - warriorsPower.Pop();
                        operators[0] = c;
                        plates.Clear();
                        foreach (var item in operators)
                        {
                            plates.Enqueue(item);
                        }
                        if (warriorsPower.Count == 0 )
                        {
                            break;
                        }
                    }
                    else if (warriorsPower.Peek() == plates.Peek())
                    {
                        warriorsPower.Pop();
                        plates.Dequeue();
                        if (plates.Count <= 0 || warriorsPower.Count <= 0)
                        {
                            break;
                        }
                    }
                    //if (temp == warriorsPower.Count)
                    //{
                    //    j--;
                    //}
                    //else if (temp > warriorsPower.Count)
                    //{
                    //    temp = warriorsPower.Count;
                    //}
                }
            }
                if (plates.Count <= 0)
                {
                    Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                }
                else if (warriorsPower.Count <= 0)
                {
                    Console.WriteLine("The people successfully repulsed the orc's attack.");
                }

                if (plates.Any())
                {
                    
                        //"Orcs left: {orc1}, {orc2}, 
                        Console.Write("Plates left: ");
                        Console.Write(string.Join(", ", plates));
                   
                }
                if (warriorsPower.Any())
                {
                    
                        //"Plates left: {plate1}, 
                        Console.Write("Orcs left: ");
                        Console.Write(string.Join(", ",warriorsPower));
                    
                }
        }
    }
}
