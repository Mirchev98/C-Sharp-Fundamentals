using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());

            string itemType = Console.ReadLine();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < entryPoint; i++)
            {
                if (itemType == "expensive")
                {
                    if (items[i] >= items[entryPoint])
                    {
                        leftSum += items[i];
                    }
                }
                else
                {
                    if (items[i] < items[entryPoint])
                    {
                        leftSum += items[i];
                    }
                }
            }

            for (int i = items.Count - 1; i > entryPoint; i--)
            {
                if (itemType == "expensive")
                {
                    if (items[i] >= items[entryPoint])
                    {
                        rightSum += items[i];
                    }
                }
                else
                {
                    if (items[i] < items[entryPoint])
                    {
                        rightSum += items[i];
                    }
                }
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}
