using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int remainder = 0;
            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = num.Length - 1; i >= 0; i--)
            {
                
                char lastNumAsChar = num[i];
                int lastNumAsDigit = int.Parse(lastNumAsChar.ToString());

                int result = lastNumAsDigit * multiplier + remainder;

                sb.Append(result % 10);
                remainder = result / 10;
            }
            if (remainder != 0)
            {
                sb.Append(remainder);
            }

            StringBuilder reversedString = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reversedString.Append(sb[i]);
            }
            Console.WriteLine(reversedString.ToString());
        }
    }
}
