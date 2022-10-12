using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.Length % 2 == 0)
            {
                char characterOne = word[word.Length / 2];
                char characterTwo = word[(word.Length / 2) - 1];
                Console.WriteLine($"{characterTwo}{characterOne}");
            }
            else
            {
                Console.WriteLine(word[word.Length / 2]);
            }
        }
    }
}
