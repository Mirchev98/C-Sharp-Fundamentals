using System;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] cmd = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            while (cmd[0] != "Decode")
            {
                switch (cmd[0])
                {
                    case "Move":
                        text = Move(text, cmd[1]);
                        break;
                    case "Insert":
                        text = Insert(text, cmd[1], cmd[2]);
                        break;
                    case "ChangeAll":
                        text = ChangeAll(text, cmd[1], cmd[2]);
                        break;
                }
                cmd = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"The decrypted message is: {text}");
        }
        private static string Move(string text, string numberOfLetters)
        {
            int lettersToMove = int.Parse(numberOfLetters);
            string letters = text.Substring(0, lettersToMove);
            text = text.Remove(0, lettersToMove);
            return text = text + letters;
        }
        private static string Insert(string text, string index, string value)
        {
            int indexToInsert = int.Parse(index);
            return text = text.Insert(indexToInsert, value);
        }
        private static string ChangeAll(string text, string toBeChange, string changeResult)
        {
            return text = text.Replace(toBeChange, changeResult);
        }
    }
}
