using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _01.National_Court
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> products = Console.ReadLine()?.Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> commands = Console.ReadLine()?.Split().ToList();

            //Tomatoes!Potatoes!Bread
            //Urgent Milk

            while (commands[0] != "Go")
            {
                string firstItem = commands[1];
                bool isItemExist = products.Contains(firstItem);
                if (!isItemExist && commands[0] == "Urgent")
                {
                    products.Insert(0, firstItem);
                }
                else if (isItemExist && commands[0] == "Unnecessary")
                {
                    products.Remove(firstItem);
                }
                else if (isItemExist && commands[0] == "Correct")
                {
                    string secondItem = commands[2];
                   int index = products.FindIndex(x => x == firstItem);
                    products[index] = secondItem;
                    //for (int i = 0; i < products.Count - 1; i++)
                    //{
                    //    if (products[i] == firstItem)
                    //    {
                    //        products[i] = secondItem;
                    //        //break;
                    //
                    //    }
                    //
                    //}
                }
                else if (isItemExist && commands[0] == "Rearrange")
                {
                    string word = string.Empty;
                    for (int i = 0; i < products.Count - 1; i++)
                    {
                        if (products[i] == firstItem)
                        {
                            word = products[i];
                            products.RemoveAt(i);
                            products.Add(word);
                            break;
                        }
                    }
                }


                commands = Console.ReadLine()?.Split().ToList();
            }
            Console.WriteLine(string.Join(", ", products));
        }
    }
}
