using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                if (commands[0] == "Delete")
                {
                    int elementToDelete = int.Parse(commands[1]);
                    for (int i = 0; i < numbersList.Count; i++)
                    {
                        if (numbersList[i] == elementToDelete)
                        {
                            numbersList.RemoveAt(i);
                        }
                    }
                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[2]);
                    int numberToInsert = int.Parse(commands[1]);
                    numbersList.Insert(index, numberToInsert);
                }
                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(" ", numbersList));
        }
    }
}
