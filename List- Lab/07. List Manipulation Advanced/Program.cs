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
            bool isChanged = false;

            while (command[0] != "end")
            {
                
                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    numbersList.Add(number);
                    isChanged = true;
                }
                else if (command[0] == "Remove")
                {
                    int number = int.Parse(command[1]);
                    numbersList.Remove(number);
                    isChanged = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    int number = int.Parse(command[1]);
                    numbersList.RemoveAt(number);
                    isChanged = true;
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbersList.Insert(index, number);
                    isChanged = true;
                }
                else if (command[0] == "Contains")
                {
                    int number = int.Parse(command[1]);
                    if (numbersList.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    foreach (int numero in numbersList)
                    {
                        if (numero % 2 == 0)
                        {
                            Console.Write($"{numero} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command[0] == "PrintOdd")
                {
                    foreach (int numero in numbersList)
                    {
                        if (numero % 2 != 0)
                        {
                            Console.Write($"{numero} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(numbersList.Sum());
                }
                else if (command[0] == "Filter")
                {
                    string condition = command[1];
                    int number = int.Parse(command[2]);
                    if (condition == "<")
                    {
                        foreach (int numero in numbersList)
                        {
                            if (numero < number)
                            {
                                Console.Write($"{numero} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if(condition == ">")
                    {
                        foreach (int numero in numbersList)
                        {
                            if (numero > number)
                            {
                                Console.Write($"{numero} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == ">=")
                    {
                        foreach (int numero in numbersList)
                        {
                            if (numero >= number)
                            {
                                Console.Write($"{numero} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == "<=")
                    {
                        foreach (int numero in numbersList)
                        {
                            if (numero <= number)
                            {
                                Console.Write($"{numero} ");
                            }
                        }
                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine().Split().ToArray();
            }

            if (isChanged)
            {
                Console.WriteLine(String.Join(" ", numbersList));
            }

        }
    }
}
