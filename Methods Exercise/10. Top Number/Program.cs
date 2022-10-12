using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int numberToCheck = i;
                bool divisableBy = Division(numberToCheck);
                bool oddDigit = OddDigitM(numberToCheck);
                if (divisableBy && oddDigit)
                {
                    Console.WriteLine(numberToCheck);
                }
            }
        }

        private static bool Division(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;


        }
        private static bool OddDigitM(int number)
        {
            int currentNum = 0;
            while (number > 0)
            {
                currentNum = number % 10;
                number /= 10;
                if (currentNum % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
