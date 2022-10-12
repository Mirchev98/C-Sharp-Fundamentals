using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading;

namespace _13._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string[] cmd = Console.ReadLine().Split(">>>");

            while (cmd[0] != "Generate")
            {
                switch (cmd[0])
                {
                    case "Contains":
                        Contains(cmd[1], password);
                        break;
                    case "Flip":
                        string position = cmd[1];
                        int start = int.Parse(cmd[2]);
                        int end = int.Parse(cmd[3]);
                        password = Flip(password, position, start, end);
                        break;
                    case "Slice":
                        int deleteStart = int.Parse(cmd[1]);
                        int deleteEnd = int.Parse(cmd[2]);
                        password = Slice(password, deleteStart, deleteEnd);
                        break;
                }
                cmd = Console.ReadLine().Split(">>>");
            }

            Console.WriteLine($"Your activation key is: {password}");
        }
        static void Contains(string substring, string pass)
        {
            if (pass.Contains(substring))
            {
                Console.WriteLine($"{pass} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }
        static string Flip(string password, string position, int start, int end)
        {
            string substring = password.Substring(start, end - start);
            string newSubstring = String.Empty;
            if (position == "Upper")
            {
                newSubstring = substring.ToUpper();
            }
            else
            {
                newSubstring = substring.ToLower();
            }
            password = password.Replace(substring, newSubstring);
            Console.WriteLine(password);
            return password;
        }
        static string Slice(string password, int deleteStart, int deleteEnd)
        {
            password = password.Remove(deleteStart, deleteEnd - deleteStart);
            Console.WriteLine(password);
            return password;
        }
    }
}
