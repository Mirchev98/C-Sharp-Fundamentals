using System;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inputBase = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(inputBase, power));
        }

        static double MathPower(double inputBase, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= inputBase;
            }

            return result;
        }
    }
}
