using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> houseParty = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                string name = commands[0];
                if (commands[2] == "going!")
                {
                    if (houseParty.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        houseParty.Add(name);
                    }

                }
                else
                {
                    if (houseParty.Contains(name))
                    {
                        houseParty.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }

            }
            foreach (string name in houseParty)
            {
                Console.WriteLine(name);
            }
        }
    }
}
