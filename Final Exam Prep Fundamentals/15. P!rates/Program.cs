using System;
using System.Collections.Generic;

namespace _15._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> towns = new Dictionary<string, List<int>>();

            string[] cmd = Console.ReadLine().Split("||");
            while (cmd[0] != "Sail")
            {
                string townName = cmd[0];
                int population = int.Parse(cmd[1]);
                int gold = int.Parse(cmd[2]);
                
                if (!towns.ContainsKey(townName))
                {
                    towns.Add(townName, new List<int>(){population, gold});
                }
                else
                {
                    towns[townName][0] += population;
                    towns[townName][1] += gold;
                }
                
                cmd = Console.ReadLine().Split("||");
            }

            string[] command = Console.ReadLine().Split("=>");

            while (command[0] != "End")
            {
                string currentTown = command[1];

                switch (command[0])
                {
                    case "Plunder":
                        int currentPop = int.Parse(command[2]);
                        int currentGold = int.Parse(command[3]);
                        
                        Console.WriteLine($"{currentTown} plundered! {currentGold} gold stolen, {currentPop} citizens killed.");
                        towns[currentTown][0] -= currentPop;
                        towns[currentTown][1] -= currentGold;
                        if (towns[currentTown][0] <= 0 || towns[currentTown][1] <= 0)
                        {
                            towns.Remove(currentTown);
                            Console.WriteLine($"{currentTown} has been wiped off the map!");
                        }
                        break;
                    case "Prosper":
                        int goldToAdd = int.Parse(command[2]);
                        if (goldToAdd <= 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            towns[currentTown][1] += goldToAdd;
                            Console.WriteLine($"{goldToAdd} gold added to the city treasury. {currentTown} now has {towns[currentTown][1]} gold.");
                        }
                        break;
                }
                
                command = Console.ReadLine().Split("=>");
            }

            if (towns.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
                foreach (var town in towns)
                {
                    Console.WriteLine($"{town.Key} -> Population: {town.Value[0]} citizens, Gold: {town.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
