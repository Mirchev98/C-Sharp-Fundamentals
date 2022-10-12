using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.ToLower();

            VowelsCounter(word);
        }

        private static void VowelsCounter(string word)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                
                if (word[i] =='a' || word[i] == 'e' || word[i] == 'o' || word[i] == 'u' || word[i] == 'i')
                {
                    counter++;
                }
                
            }
            Console.WriteLine(counter);
        }
    }
}
