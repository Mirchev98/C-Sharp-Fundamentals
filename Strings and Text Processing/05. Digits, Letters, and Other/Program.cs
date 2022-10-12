using System;

namespace _05._Digits__Letters__and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string numbers = String.Empty;
            string letters = String.Empty;
            string others = String.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    numbers += text[i];
                }
                else if (char.IsLetter(text[i]))
                {
                    letters += text[i];
                }
                else
                {
                    others += text[i];
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
