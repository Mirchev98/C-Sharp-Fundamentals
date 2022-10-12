using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordOne = Console.ReadLine();
            string wordTwo = Console.ReadLine();


            while (wordTwo.Contains(wordOne))
            {
                int start = wordTwo.IndexOf(wordOne);
                wordTwo = wordTwo.Remove(start, wordOne.Length);
            }
            Console.WriteLine(wordTwo);
        }
    }
}
