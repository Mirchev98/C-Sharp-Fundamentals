using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int explosionPower = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    explosionPower += int.Parse(text[i + 1].ToString());
                    sb.Append(text[i]);
                }
                else if (explosionPower == 0)
                {
                    sb.Append(text[i]);
                }
                else
                {
                    explosionPower--;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
