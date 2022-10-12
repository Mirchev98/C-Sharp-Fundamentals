using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] theBomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = theBomb[0];
            int power = theBomb[1];

            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] == bomb)
                {
                    int start = i - power;
                    if (start < 0)
                    {
                        start = 0;
                    }
                    int end = i + power;
                    if (end > myList.Count - 1)
                    {
                        end = myList.Count - 1;
                    }
                    for (int j = start; j <= end; j++)
                    {
                        myList[j] = 0;
                    }
                }
            }
            Console.WriteLine(myList.Sum());
        }
    }
}
