using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char newChar = (char)(text[i] + 3);
                sb.Append(newChar);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
