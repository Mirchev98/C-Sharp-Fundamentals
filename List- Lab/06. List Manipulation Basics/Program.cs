using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                int number = int.Parse(command[1]);
                if (command[0] == "Add")
                {
                    numbersList.Add(number);
                }
                else if (command[0] == "Remove")
                {
                    numbersList.Remove(number);
                }
                else if (command[0] == "RemoveAt")
                {
                    numbersList.RemoveAt(number);
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    numbersList.Insert(index, number);
                }

                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(String.Join(" ", numbersList));
        }
    }
}
