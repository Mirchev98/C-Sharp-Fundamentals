using System;
using System.Text.RegularExpressions;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<start>[\S]+)>(?<numbers>\d+)\|(?<lowerCase>[a-z]+)\|(?<upperCase>[A-Z]+)\|(?<symbols>[^<^>]\S+)<(?<end>\k<start>)(?<isIt>\S+)?";

            int numberOfPasswords = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPasswords; i++)
            {
                string password = Console.ReadLine();

                string encryption = string.Empty;

                Match match = Regex.Match(password, pattern);

                if (match.Groups["isIt"].Success)
                {
                    Console.WriteLine("Try another password!");
                    continue;
                }
                if (match.Success && match.Groups["start"].Value == match.Groups["end"].Value)
                {
                    encryption += match.Groups["numbers"].Value;
                    encryption += match.Groups["lowerCase"].Value;
                    encryption += match.Groups["upperCase"].Value;
                    encryption += match.Groups["symbols"].Value;
                    Console.WriteLine($"Password: {encryption}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
