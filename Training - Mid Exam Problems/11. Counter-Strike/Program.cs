using System;

namespace _11._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            int wonBattles = 0;
            string distance = Console.ReadLine();
            while (distance != "End of battle")
            {
                int deduction = int.Parse(distance);
                if (initialEnergy - deduction >= 0)
                {
                    initialEnergy -= deduction;
                    wonBattles++;
                    if (wonBattles % 3 == 0)
                    {
                        initialEnergy += wonBattles;
                    }
                }
                else if (initialEnergy - deduction < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {initialEnergy} energy");
                    return;
                }
                distance = Console.ReadLine();
            }
            if (distance == "End of battle")
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {initialEnergy}");
            }
        }
    }
}
