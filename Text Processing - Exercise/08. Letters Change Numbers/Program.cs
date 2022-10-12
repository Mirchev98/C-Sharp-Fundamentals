using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            foreach (var word in input)
            {
                string text = word;

                char firstChar = text[0];
                char lastChar = text[text.Length - 1];
                double number = double.Parse(text.Substring(1, text.Length - 2));

                if (firstChar >= 65 && firstChar <= 90)
                {
                    double currNum = firstChar - 64;
                    number /= currNum;
                }
                else
                {
                    double currNum = firstChar - 96;
                    number *= currNum;
                }
                if (lastChar >= 65 && lastChar <= 90)
                {
                    double currNum = lastChar - 64;
                    number -= currNum;
                }
                else
                {
                    double currNum = lastChar - 96;
                    number += currNum;
                }
                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
