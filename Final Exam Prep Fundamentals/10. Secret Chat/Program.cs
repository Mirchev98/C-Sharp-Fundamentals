using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _10._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] command = Console.ReadLine().Split(":|:");

            while (command[0] != "Reveal")
            {
                switch (command[0])
                {
                    case "InsertSpace":
                        int index = int.Parse(command[1]);
                        text = text.Insert(index, " ");
                        break;
                    case "Reverse":
                        if (text.Contains(command[1]))
                        {
                            string stringToReverse = command[1];
                            string reversedString = String.Empty;
                            for (int i = stringToReverse.Length - 1; i >= 0; i--)
                            {
                                reversedString += stringToReverse[i];
                            }

                            int start = text.IndexOf(stringToReverse);
                            int end = stringToReverse.Length;
                            text = text.Remove(start, end);
                            text += reversedString;
                        }
                        else
                        {
                            Console.WriteLine("error");
                            command = Console.ReadLine().Split(":|:");
                            continue;
                        }
                        break;
                    case "ChangeAll":
                        string toReplace = command[1];
                        string replacement = command[2];
                        text = text.Replace(toReplace, replacement);
                        break;
                }

                Console.WriteLine(text);
                command = Console.ReadLine().Split(":|:");
            }

            Console.WriteLine($"You have a new text message: {text}");
        }
    }
}
