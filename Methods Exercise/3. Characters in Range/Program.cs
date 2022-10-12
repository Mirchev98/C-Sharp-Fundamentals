using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char charOne = char.Parse(Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());

            int numOne = (int) charOne;
            int numTwo = (int)charTwo;

            int start = Math.Min(numOne, numTwo);
            int end = Math.Max(numOne, numTwo);

            AsciiPrinter(start, end);
        }

        private static void AsciiPrinter(int start, int end)
        {
            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
