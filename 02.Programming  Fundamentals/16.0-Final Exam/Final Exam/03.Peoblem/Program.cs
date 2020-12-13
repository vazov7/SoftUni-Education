using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Peoblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> peoples = new Dictionary<string, List<int>>();
            string a = Console.ReadLine();

            while (a != "Results")
            {

                List<string> cmds = a.Split(':').ToList();
                string command = cmds[0];
                string personName = cmds[1];
                bool isPersonExist = peoples.ContainsKey(personName);
                if (command == "Delete")
                {

                    if (personName == "All")
                    {
                        foreach (var item in peoples)
                        {
                            peoples.Remove(item.Key);
                           
                        }
                    }
                    if (isPersonExist)
                    {
                        peoples.Remove(personName);
                    }
                }
                else if (command == "Add")
                {
                    int health = int.Parse(cmds[2]);
                    int energy = int.Parse(cmds[3]);
                    if (!isPersonExist)
                    {// if person not exist add to peoples

                        peoples.Add(personName, new List<int>
                        {
                            {health}, {energy}
                        });
                    }
                    else
                    {
                        peoples[personName][0] += health;
                        peoples[personName][1] += energy;
                    }

                }
                else if (command == "Attack")
                {
                    int takenDamage = int.Parse(cmds[3]);
                    string defenderName = cmds[2];
                    bool isDefenderExist = peoples.ContainsKey(defenderName);
                    if (isPersonExist && isDefenderExist)
                    {
                        peoples[defenderName][0] -= takenDamage;
                        if (peoples[defenderName][0] <= 0)
                        {
                            peoples.Remove(defenderName);
                            Console.WriteLine($"{defenderName} was disqualified!");
                        }
                        peoples[personName][1] -= 1;
                        if (peoples[personName][1] <= 0)
                        {
                            peoples.Remove(personName);
                            Console.WriteLine($"{personName} was disqualified!");
                        }
                    }

                }
                

                a = Console.ReadLine();
            }
            //end of while
            Console.WriteLine($"People count: {peoples.Count}");
            // var sorted = peoples.OrderByDescending(r => r.Value[0])
            //     .ThenBy(r => r.Key);

            foreach (var item in peoples.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} - {item.Value[1]}");

            }
            //  foreach (var item in sorted)
            //{
            //}

        }
    }
}
