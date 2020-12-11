using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Heroes_of_Code_and_Logic_VII_Problem_Description
{
    class Program
    {

        //2
        //Solmyr 85 120
        //Kyrre 99 50
        //CastSpell - Kyrre - 15 - ViewEarth

        static void Main(string[] args)
        {
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                heroes.Add(input[0], new List<int>
                {
                    {int.Parse(input[1])},
                    {int.Parse(input[2])}
                });

            }

            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                List<string> cmdList = cmd.Split(" - ").ToList();

                string command = cmdList[0];
                string heroName = cmdList[1];

                if (command == "CastSpell")
                {

                    int manaNeeded = int.Parse(cmdList[2]);
                    string spellName = cmdList[3];

                    if (heroes[heroName][1] >= manaNeeded)
                    {
                        heroes[heroName][1] -= manaNeeded;

                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }

                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(cmdList[2]);
                    string attacker = cmdList[3];
                    heroes[heroName][0] -= damage;
                    if (heroes[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(cmdList[2]);
                    int a = heroes[heroName][1];
                    heroes[heroName][1] += amount;
                    if (heroes[heroName][1] > 200)
                    {
                        int recharged = 200 - a;
                        heroes[heroName][1] = 200;
                        Console.WriteLine($"{heroName} recharged for {recharged} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                else if (command == "Heal")
                {
                    int amount = int.Parse(cmdList[2]);
                    int a = heroes[heroName][0];
                    heroes[heroName][0] += amount;
                    if (heroes[heroName][0] > 100)
                    {
                        int recharged = 100 - a;
                        heroes[heroName][0] = 100;
                        Console.WriteLine($"{heroName} healed for {recharged} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }

                }
                cmd = Console.ReadLine();
            }
            var dic = heroes.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key);
            foreach (var key in dic)
            {
                int currHp = key.Value[0];
                int currMp = key.Value[1];
                Console.WriteLine(key.Key);
                //HP: {current HP}
                //MP: { current MP}
                Console.WriteLine($"HP: {currHp}");
                Console.WriteLine($"MP: {currMp}");

            }
        }



    }
}
