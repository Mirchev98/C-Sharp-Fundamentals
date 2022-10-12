using System;
using System.Text;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                string currentBan = new string('*', bannedWord.Length);

                text = text.Replace(bannedWord, currentBan.ToString());
            }
            Console.WriteLine(text);
        }
    }
}
