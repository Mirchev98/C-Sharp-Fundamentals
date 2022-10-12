using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#|])(?<name>[\w\s]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[\d]+)\1";

            string text = Console.ReadLine();
            int totalCalories = 0;

            MatchCollection matches = Regex.Matches(text, pattern);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    int currCalories = int.Parse(match.Groups["calories"].Value);
                    totalCalories += currCalories;
                }

                int days = totalCalories / 2000;

                Console.WriteLine($"You have food to last you for: {days} days!");

                foreach (Match match in matches)
                {
                    Console.WriteLine($"Item: {match.Groups["name"]}, Best before: {match.Groups["date"]}, Nutrition: {match.Groups["calories"]}");
                }
            }
            else
            {
                Console.WriteLine("You have food to last you for: 0 days!");
            }
        }
    }
}
