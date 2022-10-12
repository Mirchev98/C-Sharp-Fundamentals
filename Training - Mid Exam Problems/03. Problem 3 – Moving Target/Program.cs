using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem_3___Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (commands[0] != "End")
            {
                int index = int.Parse(commands[1]);
                int value = int.Parse(commands[2]);
                if (commands[0] == "shoot")
                {
                    if (index > 0 && index <= targets.Count - 1)
                    {
                        targets[index] -= value;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (commands[0] == "add")
                {
                    if (index < 0 || index > targets.Count - 1)
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else
                    {
                        targets.Insert(index, value);
                    }
                }
                else if (commands[0] == "strike")
                {
                    if (index + value > targets.Count - 1 || index - value < 0)
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    else
                    {
                        int start = index - value;
                        targets.RemoveRange(start, value * 2 + 1);
                    }
                }

                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            Console.WriteLine(String.Join("|", targets));
        }
    }
}