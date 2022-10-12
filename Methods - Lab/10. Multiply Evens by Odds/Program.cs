using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int sumOfEvens = SumOfEvens(number);
            int sumOfOdds = SumOfOdds(number);
            int result = MultipliedSums(sumOfEvens, sumOfOdds);

            Console.WriteLine(result);  
        }

        static int SumOfEvens(int number)
        {
            int evenSum = 0;
            while (number > 0)
            {
                int currentNum = number % 10;
                number /= 10;
                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                
            }
            return evenSum;
      
        }
        static int SumOfOdds(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int currentNum = number % 10;
                number /= 10;
                if (currentNum % 2 == 1)
                {
                    oddSum += currentNum;
                }

            }
            return oddSum;

        }

        static int MultipliedSums(int sumOfEvens, int sumOfOdds)
        {
            int result = sumOfEvens * sumOfOdds;
            return result;
        }

    }
}
