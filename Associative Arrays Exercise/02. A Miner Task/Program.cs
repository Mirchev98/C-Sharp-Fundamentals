using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerInventory = new Dictionary<string, int>();

            string command = Console.ReadLine();
            while (command != "stop")
            {
                int value = int.Parse(Console.ReadLine());

                if (!minerInventory.ContainsKey(command))
                {
                    minerInventory[command] = 0;
                }
                minerInventory[command] += value;
                command = Console.ReadLine();
            }

            foreach (var vein in minerInventory)
            {
                Console.WriteLine($"{vein.Key} -> {vein.Value}");
            }
        }
    }
}
