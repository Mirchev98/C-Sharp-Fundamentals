using System;
using System.Collections.Generic;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            string[] cmd = Console.ReadLine().Split(' ');

            while (cmd[0] != "End")
            {
                string currName = cmd[1];

                switch (cmd[0])
                {
                    case "Enroll":
                        if (heroes.ContainsKey(currName))
                        {
                            Console.WriteLine($"{currName} is already enrolled.");
                        }
                        else
                        {
                            heroes.Add(currName, new List<string>());
                        }
                        break;
                    case "Learn":
                        string spellName = cmd[2];
                        if (!heroes.ContainsKey(currName))
                        {
                            Console.WriteLine($"{currName} doesn't exist.");
                        }
                        else
                        {
                            if (heroes[currName].Contains(spellName))
                            {
                                Console.WriteLine($"{currName} has already learnt {spellName}.");
                            }
                            else
                            {
                                heroes[currName].Add(spellName);
                            }
                        }
                        break;
                    case "Unlearn":
                        string unlearnSpell = cmd[2];
                        if (!heroes.ContainsKey(currName))
                        {
                            Console.WriteLine($"{currName} doesn't exist.");
                        }
                        else
                        {
                            if (heroes[currName].Contains(unlearnSpell))
                            {
                                heroes[currName].Remove(unlearnSpell);
                            }
                            else
                            {
                                Console.WriteLine($"{currName} doesn't know {unlearnSpell}.");
                            }
                        }
                        break;
                }
                cmd = Console.ReadLine().Split(' ');
            }

            Console.WriteLine("Heroes: ");

            foreach (var hero in heroes)
            {
                string spells = string.Join(", ", hero.Value);
                Console.WriteLine($"== {hero.Key}: {spells}");
            }
        }
    }
}
