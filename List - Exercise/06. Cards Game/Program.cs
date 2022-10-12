using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (playerOne.Count > 0 && playerTwo.Count > 0)
            {
                for (int i = 0; i < playerOne.Count; i++)
                {
                    if (playerOne[i] == playerTwo[i])
                    {
                        playerOne.RemoveAt(i);
                        playerTwo.RemoveAt(i);
                    }
                    else if (playerOne[i] > playerTwo[i])
                    {
                        PlayerOneWin(playerOne, playerTwo);
                    }
                    else if (playerOne[i] < playerTwo[i])
                    {
                        PlayerTwoWin(playerOne, playerTwo);
                    }
                    i = 0;
                    break;
                }
            }
            if (playerOne.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            }
        }



        private static void PlayerOneWin(List<int> playerOne, List<int> playerTwo)
        {
            int tempNum = 0;
            tempNum = playerOne[0];
            playerOne.Add(tempNum);
            playerOne.RemoveAt(0);
            playerOne.Add(playerTwo[0]);
            playerTwo.RemoveAt(0);
        }
        private static void PlayerTwoWin(List<int> playerOne, List<int> playerTwo)
        {
            int tempNum = 0;
            tempNum = playerTwo[0];
            playerTwo.Add(tempNum);
            playerTwo.RemoveAt(0);
            playerTwo.Add(playerOne[0]);
            playerOne.RemoveAt(0);
        }
    }
}
