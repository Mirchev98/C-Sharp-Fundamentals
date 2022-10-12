using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> gaussNumbers = new List<int>();

            for (int i = 0; i < numbersList.Count / 2; i++)
            {
                int gausNumber = numbersList[i] + numbersList[numbersList.Count - 1 - i];
                gaussNumbers.Add(gausNumber);
            }
            
            if (numbersList.Count % 2 != 0)
            {
                gaussNumbers.Add(numbersList[numbersList.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", gaussNumbers));
        }
    }
}
