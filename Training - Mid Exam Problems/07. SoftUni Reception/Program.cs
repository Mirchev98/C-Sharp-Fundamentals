using System;

namespace _07._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeeOne = int.Parse(Console.ReadLine());
            int employeeTwo = int.Parse(Console.ReadLine());
            int employeeThree = int.Parse(Console.ReadLine());
            int answers = employeeOne + employeeTwo + employeeThree;
            int students = int.Parse(Console.ReadLine());

            int hours = 0;
            
            while (true)
            {
                if (students <= 0)
                {
                    break;
                }
                hours++;
                
                if (hours % 4 == 0)
                {
                    continue;
                }
                students -= answers;

            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
