using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _14._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string emojiPatter = @"(\*{2}|:{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string treshHoldPattern = @"\d";
            long treshHold = 1;

            string text = Console.ReadLine();

            MatchCollection coolTreshold = Regex.Matches(text, treshHoldPattern);
            
            foreach (Match num in coolTreshold)
            {
                int currNum = int.Parse(num.ToString());
                treshHold *= currNum;
            }

            Console.WriteLine($"Cool threshold: {treshHold}");

            MatchCollection emojis = Regex.Matches(text, emojiPatter);
            
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojis)
            {
                string currentEmoji = emoji.Groups["emoji"].Value;
                long currTreshold = currentEmoji.ToCharArray().Sum(s => s);
                if (currTreshold >= treshHold)
                {
                    Console.WriteLine(emoji.Value);
                }
            }
        }
    }
}
