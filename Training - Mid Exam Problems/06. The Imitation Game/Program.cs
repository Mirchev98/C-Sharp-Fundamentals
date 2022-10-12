using System;
using System.Collections.Generic;

namespace _06._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> letters = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                char letterToInsert = text[i];
                letters.Add(letterToInsert);
            }

            string[] commands = Console.ReadLine().Split("|");

            while (commands[0] != "Decode")
            {
                if (commands[0] == "Move")
                {
                    int moves = int.Parse(commands[1]);
                    for (int i = 0; i < moves; i++)
                    {
                        letters.Add(letters[0]);
                        letters.RemoveAt(0);
                    }
                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    string value = commands[2];
                    int indexToTake = 0;
                    for (int i = 0; i < value.Length; i++)
                    {
                        letters.Insert(index, value[indexToTake]);
                        indexToTake++;
                        index++;
                    }
                }
                else if (commands[0] == "ChangeAll")
                {
                    char substring = char.Parse(commands[1]);
                    char replacement = char.Parse(commands[2]);

                    for (int i = 0; i < letters.Count - 1; i++)
                    {
                        if (letters[i] == substring)
                        {
                            letters[i] = replacement;
                        }
                    }
                }
                commands = Console.ReadLine().Split("|");
            }

            string decrypted = string.Empty;
            foreach (var item in letters)
            {
                decrypted += item;
            }
            Console.WriteLine($"The decrypted message is: {decrypted}");
        }
    }
}
