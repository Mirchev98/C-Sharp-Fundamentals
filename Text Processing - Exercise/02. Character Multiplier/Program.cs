using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string one = words[0];
            string two = words[1];

            int result = SumFromStrings(one, two);
            Console.WriteLine(result);
        }

        private static int SumFromStrings(string one, string two)
        {
            int result = 0;
            int end = 0;
            if (one.Length > two.Length)
            {
                end = one.Length;
                for (int i = 0; i < two.Length; i++)
                {
                    result += (int)(one[i] * two[i]);
                }
                for (int i = two.Length; i < one.Length; i++)
                {
                    result += one[i];
                }

            }
            else
            {
               end = two.Length;
               for (int i = 0; i < one.Length; i++)
               {
                    result += (int)(one[i] * two[i]);
               }
               for (int i = one.Length; i < two.Length; i++)
               {
                    result += two[i];
               }
            }

            return result;
        }
    }
}
