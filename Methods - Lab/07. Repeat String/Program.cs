using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int printNumbers = int.Parse(Console.ReadLine());
            PrintingStrings(inputString, printNumbers);
        }

        static string PrintingStrings(string inputString, int printNumbers)
        {
            for (int i = 0; i < printNumbers; i++)
            {
                Console.Write(inputString);
            }
            return inputString;
        }
    }
}
