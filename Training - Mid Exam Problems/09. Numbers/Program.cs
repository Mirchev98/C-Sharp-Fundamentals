using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            double average = numbers.Sum() / numbers.Count();
            int counter = 0;
            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (counter == 5)
                {
                    return;
                }
                if (numbers[i] > average)
                {
                    Console.Write(numbers[i] + " ");
                    counter++;
                }

            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
