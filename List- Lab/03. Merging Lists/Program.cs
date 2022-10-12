using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mergedList = new List<int>();

            int end = Math.Max(listOne.Count, listTwo.Count);

            for (int i = 0; i < end; i++)
            {
                if (listOne.Count > i)
                {
                    mergedList.Add(listOne[i]);
                }

                if (listTwo.Count > i)
                {
                    mergedList.Add(listTwo[i]);
                }
            }

            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
