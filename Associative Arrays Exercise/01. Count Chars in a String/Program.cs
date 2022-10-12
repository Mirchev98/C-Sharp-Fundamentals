using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] characters = Console.ReadLine().ToCharArray();

            Dictionary<char, int> occurances = new Dictionary<char, int>();

            foreach (var letter in characters)
            {
                if (letter != ' ')
                {
                    if (!occurances.ContainsKey(letter))
                    {
                        occurances[letter] = 0;
                    }
                    occurances[letter]++;
                }
                    
            }
            foreach (var character in occurances)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
