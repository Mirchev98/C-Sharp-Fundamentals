using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);

            string[] wantedFile = filePath[filePath.Length - 1].Split(".", StringSplitOptions.RemoveEmptyEntries);
            string fileName = wantedFile[0];
            string prop = wantedFile[1];
            
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {prop}");
        }
    }
}
