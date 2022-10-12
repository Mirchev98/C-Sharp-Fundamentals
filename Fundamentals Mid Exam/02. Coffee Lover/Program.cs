using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine().Split().ToList();
            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                switch (commands[0])
                {
                    case "Include":
                        string coffeeToInclude = commands[1];
                        Include(coffeeToInclude, coffees);
                        break;
                    case "Remove":
                        string side = commands[1];
                        int numbersToRemove = int.Parse(commands[2]);
                        if (numbersToRemove <= coffees.Count)
                        {
                            Remover(side, numbersToRemove, coffees);
                        }                     
                        break;
                    case "Prefer":
                        int indexOne = int.Parse(commands[1]);
                        int indexTwo = int.Parse(commands[2]);
                        if ((indexOne >= 0 && indexTwo >= 0) && (indexOne <= coffees.Count - 1 && indexTwo <= coffees.Count - 1))
                        {
                            Preference(indexOne, indexTwo, coffees);
                        }
                        break;
                    case "Reverse":
                        coffees.Reverse();
                        break;
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffees));
        }
        private static void Include(string coffeeToInclude, List<string> coffees)
        {
            coffees.Add(coffeeToInclude);
        }
        private static void Remover(string side, int numbersToRemove, List<string> coffees)
        {
            if (side == "first")
            {
                for (int i = 0; i <= numbersToRemove - 1 ; i++)
                {
                    coffees.RemoveAt(0);
                }
            }
            else
            {
                coffees.Reverse();
                for (int i = 0; i <= numbersToRemove - 1; i++)
                {
                    coffees.RemoveAt(0);
                }
                coffees.Reverse();
            }
        }
        private static void Preference(int indexOne, int indexTwo, List<string> coffees)
        {
            string temp = coffees[indexOne];
            coffees[indexOne] = coffees[indexTwo];
            coffees[indexTwo] = temp;
        }
    }
}
