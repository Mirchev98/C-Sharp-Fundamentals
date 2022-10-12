using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "swap":
                        int indexOne = int.Parse(commands[1]);
                        int indexTwo = int.Parse(commands[2]);
                        Swap(indexOne, indexTwo, numbers);
                        break;
                    case "multiply":
                        int multiplyOne = int.Parse(commands[1]);
                        int multiplyTwo = int.Parse(commands[2]);
                        Multiplier(multiplyOne, multiplyTwo, numbers);
                        break;
                    case "decrease":
                        Decreasing(numbers);
                        break;
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
        
        private static void Swap(int indexOne, int indexTwo, List<int>numbers)
        {
            int tempNum = numbers[indexTwo];
            numbers[indexTwo] = numbers[indexOne];
            numbers[indexOne] = tempNum;
        }
        private static void Multiplier(int multiplyOne, int multiplyTwo, List<int> numbers)
        {
            numbers[multiplyOne] *= numbers[multiplyTwo];
        }
        private static void Decreasing(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }
    }
}
