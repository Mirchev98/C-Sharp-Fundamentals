using System;

namespace Methods_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            GetMin(numOne, numTwo, numThree);
        }

        private static void GetMin(int numOne, int numTwo, int numThree)
        {
            Console.WriteLine(Math.Min(numOne, Math.Min(numTwo, numThree)));
        }
    }
}
