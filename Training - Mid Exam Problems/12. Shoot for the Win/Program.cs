using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int shotTargets = 0;
            while (command != "End")
            {
                int index = int.Parse(command);
                if (index < 0 || index > targets.Count - 1)
                {
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    TargetPractice(index, shotTargets, targets);
                    shotTargets++;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
        }

        private static void TargetPractice(int index, int shotTargets, List<int> targets)
        {
            if (targets[index] == -1)
            {
                return;
            }
            else
            {
                int tempNum = targets[index];
                targets[index] = -1;              
                for (int i = 0; i < targets.Count; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }
                    else
                    {
                        if (targets[i] > tempNum)
                        {
                            targets[i] -= tempNum;
                        }
                        else if (targets[i] <= tempNum)
                        {
                            targets[i] += tempNum;
                        }
                    }
                }
            }
            return;
        }
    }
}
