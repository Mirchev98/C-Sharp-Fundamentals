using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (numbersList[i] < 0)
                {
                    numbersList.RemoveAt(i);
                    i--;
                }
            }

            numbersList.Reverse();
            
            if (numbersList.Count > 0)
            {
                Console.WriteLine(String.Join(" ", numbersList));
            }
            else
            {
                Console.WriteLine("empty");
            }
            

            
        }
    }
}
