using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([=/])(?<location>[A-Z][A-Za-z]{2,})\1";
            int points = 0;

            MatchCollection matches = Regex.Matches(text, pattern);
            List<string> result = new List<string>();

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    points += match.Value.Length - 2;
                    result.Add(match.Groups["location"].Value);
                }

                Console.WriteLine($"Destinations: {String.Join(", ", result)}");
                Console.WriteLine($"Travel Points: {points}");
            }
            else
            {
                Console.WriteLine("Destinations: ");
                Console.WriteLine("Travel Points: 0");
            }


        }
    }
}
