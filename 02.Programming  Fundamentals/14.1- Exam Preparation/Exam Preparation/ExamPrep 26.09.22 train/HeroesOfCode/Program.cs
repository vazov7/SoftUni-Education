using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                heroes.Add(input[0], new int[] { int.Parse(input[1]), int.Parse(input[2]) });
            }

            string cmd = string.Empty;
            while ((cmd = Console.ReadLine()) != "End")
            {
                List<string> command = cmd
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (command[0] == "CastSpell")
                {
                    if (int.Parse(command[2]) > heroes[command[1]][1])
                    {
                        Console.WriteLine($"{command[1]} does not have enough MP to cast {command[3]}!");
                    }
                    else
                    {
                        heroes[command[1]][1] -= int.Parse(command[2]);
                        Console.WriteLine($"{command[1]} has successfully cast {command[3]} and now has {heroes[command[1]][1]} MP!");
                    }
                }
                else if (command[0] == "TakeDamage")
                {
                    heroes[command[1]][0] -= int.Parse(command[2]);
                    if (heroes[command[1]][0] <= 0)
                    {
                        heroes.Remove(command[1]);
                        Console.WriteLine($"{command[1]} has been killed by {command[3]}!");
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} was hit for {command[2]} HP by {command[3]} and now has {heroes[command[1]][0]} HP left!");
                    }

                }
                else if (command[0] == "Recharge")
                {
                    if ((int.Parse(command[2]) + heroes[command[1]][1]) > 200)
                    {
                        int amounthRecovery = 200 - heroes[command[1]][1];
                        heroes[command[1]][1] += amounthRecovery;
                        Console.WriteLine($"{command[1]} recharged for {amounthRecovery} MP!");
                    }
                    else
                    {
                        heroes[command[1]][1] += int.Parse(command[2]);
                        Console.WriteLine($"{command[1]} recharged for {int.Parse(command[2])} MP!");
                    }
                }
                else if (command[0] == "Heal")
                {
                    if ((int.Parse(command[2]) + heroes[command[1]][0]) > 100)
                    {
                        int amounthRecovery = 100 - heroes[command[1]][0];
                        heroes[command[1]][0] += amounthRecovery;
                        Console.WriteLine($"{command[1]} healed for {amounthRecovery} HP!");
                    }
                    else
                    {
                        heroes[command[1]][0] += int.Parse(command[2]);
                        Console.WriteLine($"{command[1]} healed for {int.Parse(command[2])} HP!");
                    }
                }


            }
            //Dictionary<string, int[]> orderedHeroes=
            //    new Dictionary<string, int[]>(heroes.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key));
            //foreach (var item in orderedHeroes)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine($"HP: {orderedHeroes[item.Key][0]}");
            //    Console.WriteLine($"MP: {orderedHeroes[item.Key][1]}");
            //}
            foreach (var item in heroes)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"HP: {heroes[item.Key][0]}");
                Console.WriteLine($"MP: {heroes[item.Key][1]}");
            }


        }

    }
}
