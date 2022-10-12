using System;
using System.Text;

namespace _07._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = Console.ReadLine();
            string[] cmd = Console.ReadLine().Split(" ");

            while (cmd[0] != "Done")
            {
                switch (cmd[0])
                {
                    case "TakeOdd":
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 1; i < result.Length; i+= 2)
                        {
                            sb.Append(result[i]);
                        }
                        result = sb.ToString();
                        break;
                    }
                    case "Cut":
                    {
                        int index = int.Parse(cmd[1]);
                        int length = int.Parse(cmd[2]);
                        string substring = result.Substring(index, length);
                        int removeIndex = result.IndexOf(substring);
                        int lastIndex = substring.Length;
                        result = result.Remove(removeIndex, lastIndex);
                        break;
                    }
                    case "Substitute":
                    {
                        string substring = cmd[1];
                        string replacement = cmd[2];
                        if (result.Contains(substring))
                        {
                            result = result.Replace(substring, replacement);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                            cmd = Console.ReadLine().Split(" ");
                            continue;
                        }
                        break;
                    }
                }
                Console.WriteLine(result);
                cmd = Console.ReadLine().Split(" ");
            }

            Console.WriteLine($"Your password is: {result}");
        }
    }
}
