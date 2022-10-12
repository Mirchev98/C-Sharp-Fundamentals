using System;
using System.Collections.Generic;
using System.Linq;

namespace _13._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shopping = Console.ReadLine().Split("!").ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "Go")
            {
                switch (command[0])
                {
                    case "Urgent":
                        string item = command[1];
                        Urgent(item, shopping);
                        break;
                    case "Unnecessary":
                        string unItem = command[1];
                        Unnecessery(unItem, shopping);
                        break;
                    case "Correct":
                        string oldItem = command[1];
                        string correction = command[2];
                        Correction(oldItem, correction, shopping);
                        break;
                    case "Rearrange":
                        string movable = command[1];
                        Movable(movable, shopping);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", shopping));
        }

        private static void Movable(string movable, List<string> shopping)
        {
            if (shopping.Contains(movable))
            {
                shopping.Add(movable);
                shopping.Remove(movable);
            }
        }

        private static void Correction(string oldItem, string correction, List<string> shopping)
        {
            if (shopping.Contains(oldItem))
            {
                for (int i = 0; i < shopping.Count; i++)
                {
                    if (shopping[i] == oldItem)
                    {
                        shopping[i] = correction;
                        return;
                    }
                }
            }
        }

        private static void Unnecessery(string unItem, List<string> shopping)
        {
            if (shopping.Contains(unItem))
            {
                shopping.Remove(unItem);
            }
        }

        private static void Urgent(string item, List<string> shopping)
        {
            if (!shopping.Contains(item))
            {
                shopping.Insert(0, item);
            }
        }
    }
}
