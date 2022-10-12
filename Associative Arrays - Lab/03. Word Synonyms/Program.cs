using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonims = new Dictionary<string, List<string>>();

            int words = int.Parse(Console.ReadLine());

            for (int i = 0; i < words; i++)
            {
                string currWord = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (!synonims.ContainsKey(currWord))
                {
                    synonims.Add(currWord, new List<string>());
                }
                synonims[currWord].Add(synonim);
            }

            foreach (var word in synonims)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
