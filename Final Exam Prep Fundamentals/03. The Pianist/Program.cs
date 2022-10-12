using System;
using System.Collections.Generic;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> pieceComposer = new Dictionary<string, string>();
            Dictionary<string, string> pieceKey = new Dictionary<string, string>();

            int numberOfInitialPieces = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInitialPieces; i++)
            {
                string[] currInput = Console.ReadLine().Split("|");
                pieceComposer.Add(currInput[0], currInput[1]);
                pieceKey.Add(currInput[0], currInput[2]);
            }

            string[] command = Console.ReadLine().Split("|");
            
            while (command[0] != "Stop")
            {
                switch (command[0])
                {
                    case "Add":
                        string currPiece = command[1];
                        string currComposer = command[2];
                        string currKey = command[3];
                        if (!pieceComposer.ContainsKey(currPiece))
                        {
                            pieceComposer.Add(currPiece, currComposer);
                            pieceKey.Add(currPiece, currKey);
                            Console.WriteLine($"{currPiece} by {currComposer} in {currKey} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{currPiece} is already in the collection!");
                        }
                        break;
                    case "Remove":
                        string pieceToRemove = command[1];
                        if (!pieceComposer.ContainsKey(pieceToRemove))
                        {
                            Console.WriteLine($"Invalid operation! {pieceToRemove} does not exist in the collection.");
                        }
                        else
                        {
                            pieceComposer.Remove(pieceToRemove);
                            pieceKey.Remove(pieceToRemove);
                            Console.WriteLine($"Successfully removed {pieceToRemove}!");
                        }
                        break;
                    case "ChangeKey":
                        string pieceOfChangedKey = command[1];
                        string newKey = command[2];
                        if (!pieceKey.ContainsKey(pieceOfChangedKey))
                        {
                            Console.WriteLine($"Invalid operation! {pieceOfChangedKey} does not exist in the collection.");
                        }
                        else
                        {
                            pieceKey[pieceOfChangedKey] = newKey;
                            Console.WriteLine($"Changed the key of {pieceOfChangedKey} to {newKey}!");
                        }
                        break;
                }
                command = Console.ReadLine().Split("|");
            }

            foreach (var piece in pieceComposer)
            {
                string currentPiece = piece.Key;
                string currentComposer = piece.Value;

                foreach (var key in pieceKey)
                {
                    if (key.Key == currentPiece)
                    {
                        Console.WriteLine($"{currentPiece} -> Composer: {currentComposer}, Key: {key.Value}");
                    }
                }
            }
        }
    }
}
