using System;
using System.Data;
using System.Text;

namespace _04._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            string[] command = Console.ReadLine().Split(":");
            
            while (command[0]!= "Travel")
            {
                switch (command[0])
                {
                    case "Add Stop":
                        string toInsert = command[2];
                        int index = int.Parse(command[1]);
                        if (index >= 0 && index < text.Length)
                        {
                            text = text.Insert(index, toInsert);
                            Console.WriteLine(text);
                        }
                        else
                        {
                            Console.WriteLine(text);
                        }
                        break;
                    case "Remove Stop":
                        int start = int.Parse(command[1]);
                        int end = int.Parse(command[2]);
                        if (start >= 0 && end < text.Length)
                        {
                            text = text.Remove(start, end - start + 1);
                            Console.WriteLine(text);
                        }
                        else
                        {
                            Console.WriteLine(text);
                        }
                        break;
                    case "Switch":
                        string oldString = command[1];
                        string newString = command[2];
                        if (text.Contains(oldString))
                        {
                            text = text.Replace(oldString, newString);
                            Console.WriteLine(text);
                        }
                        else
                        {
                            Console.WriteLine(text);
                        }
                        break;
                    
                }
                
                command = Console.ReadLine().Split(":");

            }

            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
