using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.XPath;

namespace _11._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<seps>[@#])(?<wordOne>[A-z]{2,})\k<seps>\k<seps>(?<wordTwo>[A-z]{2,})\k<seps>";
            List<string> resultFirst = new List<string>();
            List<string> resultSecond = new List<string>();
            List<string> printed = new List<string>();

            MatchCollection matches = Regex.Matches(text, pattern);
            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                foreach (Match match in matches)
                {
                    string firstWord = match.Groups["wordOne"].Value;
                    string secondWord = match.Groups["wordTwo"].Value;
                    bool areEqual = true;
                    int index = 0;
                    if (firstWord.Length != secondWord.Length)
                    {
                        continue;
                    }
                    for (int i = firstWord.Length - 1; i >= 0; i--)
                    {
                        if (firstWord[i] != secondWord[index])
                        {
                            areEqual = false;
                            break;
                        }

                        index++;
                    }

                    if (areEqual)
                    {
                        resultFirst.Add(firstWord);
                        resultSecond.Add(secondWord);
                    }
                }

                if (resultFirst.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    int counterOne = -1;
                    foreach (var res in resultFirst)
                    {
                        counterOne++;
                        if (counterOne == 0)
                        {
                            if (!printed.Contains(res))
                            {
                                Console.Write($"{res} <=> {resultSecond[counterOne]}");
                            }
                        }
                        else
                        {
                            if (!printed.Contains(res))
                            {
                                Console.Write($", {res} <=> {resultSecond[counterOne]}");
                            }
                        }
                        
                        printed.Add(res);
                    }
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }

            }
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
