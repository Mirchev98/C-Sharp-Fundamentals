using System;
using System.Collections.Generic;

namespace _09._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, int> heroHP = new Dictionary<string, int>();
            Dictionary<string, int> heroMana = new Dictionary<string, int>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                string heroName = cmd[0];
                int heroHealth = int.Parse(cmd[1]);
                int heroM = int.Parse(cmd[2]);
                heroHP.Add(heroName, heroHealth);
                heroMana.Add(heroName, heroM);
            }

            string[] command = Console.ReadLine().Split(" - ");
            while (command[0] != "End")
            {
                string heroName = command[1];
                int number = int.Parse(command[2]);
                int currentHP = heroHP[heroName];
                int currentMP = heroMana[heroName];
                switch (command[0])
                {
                    case "CastSpell":
                        string spellName = command[3];
                        if (currentMP - number >= 0)
                        {
                            heroMana[heroName] -= number;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroMana[heroName]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        string attacker = command[3];
                        if (currentHP - number <= 0)
                        {
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                            heroHP.Remove(heroName);
                            heroMana.Remove(heroName);
                        }
                        else
                        {
                            heroHP[heroName] -= number;
                            Console.WriteLine($"{heroName} was hit for {number} HP by {attacker} and now has {heroHP[heroName]} HP left!");
                        }
                        break;
                    case "Recharge":
                        if (currentMP + number > 200)
                        {
                            int amountRecovered = 200 - heroMana[heroName];
                            heroMana[heroName] = 200;
                            Console.WriteLine($"{heroName} recharged for {amountRecovered} MP!");
                        }
                        else
                        {
                            heroMana[heroName] += number;
                            Console.WriteLine($"{heroName} recharged for {number} MP!");
                        }
                        break;
                    case "Heal":
                        if (currentHP + number > 100)
                        {
                            int amountRecovered = 100 - heroHP[heroName];
                            heroHP[heroName] = 100;
                            Console.WriteLine($"{heroName} healed for {amountRecovered} HP!");
                        }
                        else
                        {
                            heroHP[heroName] += number;
                            Console.WriteLine($"{heroName} healed for {number} HP!");
                        }
                        break;
                }
                command = Console.ReadLine().Split(" - ");
            }

            foreach (var hero in heroHP)
            {
                foreach (var heroo in heroMana)
                {
                    if (hero.Key == heroo.Key)
                    {
                        Console.WriteLine($"{hero.Key}");
                        Console.WriteLine($"  HP: {hero.Value}");
                        Console.WriteLine($"  MP: {heroo.Value}");
                    }
                }
            }
        }
    }
}
