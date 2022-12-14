using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();


            switch (type)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstInt, secondInt));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString, secondString));
                    break;
            }
        }

        static int GetMax(int firstInt, int secondInt)
        {
            if (firstInt > secondInt)
            {
                return firstInt;
            }
            else
            {
                return secondInt;
            }
        }

        static string GetMax(string firstString, string secondString)
        {
            int result = firstString.CompareTo(secondString);
            if (result > 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
    }
}
