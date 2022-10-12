using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.__Memory_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] tokens = Console.ReadLine().Split();
            int moves = 0;

            while (tokens[0] != "end")
            {
                moves++;
                int elementOne = int.Parse(tokens[0]);
                int elementTwo = int.Parse(tokens[1]);

                EqualElements(elementOne, elementTwo, numbers, moves);

                if (numbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }
                tokens = Console.ReadLine().Split();
            }
            if (numbers.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static void EqualElements(int elementOne, int elementTwo, List<string> numbers, int moves)
        {
            if (elementOne == elementTwo)
            {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                string numberToInsert = $"-{moves}a";
                numbers.Insert(numbers.Count / 2, numberToInsert);
                numbers.Insert(numbers.Count / 2, numberToInsert);
                return;
            }
            else if (elementOne < 0 || elementTwo < 0 || elementOne > numbers.Count - 1 || elementTwo > numbers.Count - 1)
            {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                string numberToInsert = $"-{moves}a";
                numbers.Insert(numbers.Count / 2, numberToInsert);
                numbers.Insert(numbers.Count / 2, numberToInsert);
                return;
            }
            
            if (numbers[elementOne] == numbers[elementTwo])
            {
                Console.WriteLine($"Congrats! You have found matching elements - {numbers[elementOne]}!");
                numbers.RemoveAt(elementOne);
                if (elementTwo - 1 < 0)
                {
                    numbers.RemoveAt(elementTwo);
                }
                else
                {
                    numbers.RemoveAt(elementTwo - 1);
                }
                return;
            }
            else if (numbers[elementOne] != numbers[elementTwo])
            {
                Console.WriteLine("Try again!");
                return;
            }
        }
    }
}
