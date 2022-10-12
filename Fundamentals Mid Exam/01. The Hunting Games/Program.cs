using System;

namespace _01._The_Hunting_Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerPerson = double.Parse(Console.ReadLine());
            double foodPerPerson = double.Parse(Console.ReadLine());
            bool enoughEnergy = true;
            double totalWaterNeeded = (waterPerPerson * players) * days;
            double totalFoodNeeded = (foodPerPerson * players) * days;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                energy -= energyLoss;
                if (energy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFoodNeeded:f2} food and {totalWaterNeeded:f2} water.");
                    enoughEnergy = false;
                    break;
                }

                if (i % 2 == 0)
                {
                    energy *= 1.05;
                    totalWaterNeeded *= 0.7;
                }
                
                if (i % 3 == 0)
                {
                    totalFoodNeeded -= totalFoodNeeded / players;
                    energy *= 1.1;
                }
            }

            if (enoughEnergy)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
        }
    }
}
