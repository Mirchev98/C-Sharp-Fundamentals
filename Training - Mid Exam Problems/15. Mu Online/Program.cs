using System;
using System.Collections.Generic;
using System.Linq;

namespace _15._Mu_Online
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");
            int initialHealth = 100;
            int initialCoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string command = rooms[i];

                string[] currentRoom = command.Split(" ");

                if (currentRoom[0] == "potion")
                {
                    int healAmount = int.Parse(currentRoom[1]);
                    if (initialHealth + healAmount >= 100)
                    {
                        int health = 100 - initialHealth;
                        initialHealth = 100;
                        Console.WriteLine($"You healed for {health} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                    else
                    {
                        initialHealth += healAmount;
                        Console.WriteLine($"You healed for {initialHealth - healAmount} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                }
                else if (currentRoom[0] == "chest")
                {
                    initialCoins += int.Parse(currentRoom[1]);
                    Console.WriteLine($"You found {currentRoom[1]} bitcoins.");
                }
                else
                {
                    string monster = currentRoom[0];
                    int attack = int.Parse(currentRoom[1]);
                    if (initialHealth - attack <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                    else
                    {
                        initialHealth -= attack;
                        Console.WriteLine($"You slayed {monster}.");
                    }
                }

                if (i == rooms.Length - 1)
                {
                    Console.WriteLine("You've made it!");
                    Console.WriteLine($"Bitcoins: {initialCoins}");
                    Console.WriteLine($"Bitcoins: {initialHealth}");
                    return;
                }
            }
        }
    }
}
