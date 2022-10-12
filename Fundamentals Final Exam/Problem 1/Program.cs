using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();

            string[] cmd = Console.ReadLine().Split(' ');

            while (cmd[0] != "Abracadabra")
            {
                switch (cmd[0])
                {
                    case "Abjuration":
                        spell = spell.ToUpper();
                        Console.WriteLine(spell);
                        break;
                    case "Necromancy":
                        spell = spell.ToLower();
                        Console.WriteLine(spell);
                        break;
                    case "Illusion":
                        int index = int.Parse(cmd[1]);
                        string letter = cmd[2];
                        if (index >= spell.Length || index < 0)
                        {
                            Console.WriteLine("The spell was too weak.");
                        }
                        else
                        {
                            StringBuilder sb = new StringBuilder(spell);
                            sb.Remove(index, 1);
                            sb.Insert(index, letter);
                            spell = sb.ToString();
                            Console.WriteLine("Done!");
                        }
                        break;
                    case "Divination":
                        string subOne = cmd[1];
                        string subTwo = cmd[2];
                        if (spell.Contains(subOne))
                        {
                            spell = spell.Replace(subOne, subTwo);
                            Console.WriteLine(spell);
                        }
                        break;
                    case "Alteration":
                        string currSubstring = cmd[1];
                        if (spell.Contains(currSubstring))
                        {
                            spell = spell.Replace(currSubstring, string.Empty);
                            Console.WriteLine(spell);
                        }
                        break;
                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }
                cmd = Console.ReadLine().Split(' ');
            }
        }
    }
}
