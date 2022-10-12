using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine().Split();

            Dictionary<string, int> occurances = new Dictionary<string, int>();

            foreach (var word in sentence)
            {
                string currentWord = word.ToLower();
                if (!occurances.ContainsKey(currentWord))
                {
                    occurances[currentWord] = 0;
                }
                occurances[currentWord]++;
            }
            foreach (var occurance in occurances)
            {
                if (occurance.Value % 2 != 0)
                {
                    Console.Write(occurance.Key + " ");
                }
            }
        }
    }
}
