using System;

namespace Methods___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(numberChecker(number));
        }

        static string numberChecker(int number)
        {
            string answer = String.Empty;
            if (number > 0)
            {
                answer = $"The number {number} is positive.";
            }
            else if (number < 0)
            {
                answer = $"The number {number} is negative.";
            }
            else
            {
                answer = $"The number {number} is zero.";
            }

            return answer;
        }
    }
}
