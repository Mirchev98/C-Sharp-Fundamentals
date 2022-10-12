using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            UpperHalf(length);
            LowerHalf(length);
        }

        static void UpperHalf(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        static void LowerHalf(int length)
        {
            for (int i = length-1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
