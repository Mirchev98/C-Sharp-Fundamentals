using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace _06._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlants = int.Parse(Console.ReadLine());
            Dictionary<string, int> rarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> rating = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfPlants; i++)
            {
                string[] tokens = Console.ReadLine().Split("<->");
                int currRarity = int.Parse(tokens[1].ToString());
                if (!rarity.ContainsKey(tokens[0]))
                {
                    rarity.Add(tokens[0], 0);
                }
                rarity[tokens[0]] = currRarity;
            }

            foreach (var plant in rarity)
            {
                rating.Add(plant.Key, new List<double>());
            }

            char[] separators = { ':', '-', ' ' };
            string[] commands = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            while (commands[0] != "Exhibition")
            {
                switch (commands[0])
                {
                    case "Rate":
                        if (!rating.ContainsKey(commands[1]))
                        {
                            Console.WriteLine("error");
                            break;
                        }
                        double currentItRating = double.Parse(commands[2].ToString());
                        rating[commands[1]].Add(currentItRating);
                        break;
                    case "Update":
                        if (!rarity.ContainsKey(commands[1]))
                        {
                            Console.WriteLine("error");
                            break;
                        }
                        int swappedRarity = int.Parse(commands[2].ToString());
                        rarity[commands[1]] = swappedRarity;
                        break;
                    case "Reset":
                        if (!rating.ContainsKey(commands[1]))
                        {
                            Console.WriteLine("error");
                            break;
                        }
                        rating[commands[1]] = new List<double>();
                        break;
                }
                commands = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in rarity)
            {
                int currRarity = plant.Value;

                foreach (var currPlant in rating)
                {
                    double averageValue = 0;
                    if (currPlant.Value.Count > 0)
                    {
                        foreach (var currentRating in currPlant.Value)
                        {
                            averageValue += currentRating;
                        }

                        averageValue /= currPlant.Value.Count;
                    }
                    if (plant.Key == currPlant.Key)
                    {
                        Console.WriteLine($"- {currPlant.Key}; Rarity: {currRarity}; Rating: {averageValue:f2}");
                    }
                }
            }

        }
    }
}
