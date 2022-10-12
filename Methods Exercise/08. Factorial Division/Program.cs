using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            double factorialOne = Factorial(numOne);
            double factorialTwo = Factorial(numTwo);

            double result = factorialOne / factorialTwo;
            Console.WriteLine($"{result:f2}");
        }

        static double Factorial(int number)
        {
            double sum = 1;
            for (int i = 2; i <= number; i++)
            {
                sum *= i;
            }
            return sum;
            
        }
    }
}
