using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "End")
            {
                if (commands[0] == "Add")
                {
                    int workingNumber = int.Parse(commands[1]);
                    numbersList.Add(workingNumber);
                }
                else if (commands[0] == "Insert")
                {
                    if (int.Parse(commands[2]) > numbersList.Count - 1 || int.Parse(commands[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        commands = Console.ReadLine().Split().ToArray();
                        continue;
                    }
                    int workingNumber = int.Parse(commands[1]);
                    int integer = int.Parse(commands[2]);
                    numbersList.Insert(integer, workingNumber);
                }
                else if (commands[0] == "Remove")
                {
                    if (int.Parse(commands[1]) > numbersList.Count - 1 || int.Parse(commands[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        commands = Console.ReadLine().Split().ToArray();
                        continue;
                    }
                    int workingNumber = int.Parse(commands[1]);
                    numbersList.RemoveAt(workingNumber);
                }
                else if (commands[0] == "Shift")
                {
                    if (commands[1] == "left")
                    {
                        int newIndex = int.Parse(commands[2]);
                        for (int i = 0; i < newIndex; i++)
                        {
                            numbersList.Add(numbersList[0]);
                            numbersList.RemoveAt(0);
                        }

                    }
                    else if (commands[1] == "right")
                    {
                        int newIndex = int.Parse(commands[2]);
                        for (int i = 0; i < newIndex; i++)
                        {
                            numbersList.Insert(0, numbersList[numbersList.Count - 1]);
                            numbersList.RemoveAt(numbersList.Count - 1);
                        }
                    }
                }
                commands = Console.ReadLine().Split().ToArray();
            }
            
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
