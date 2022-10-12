using System;

namespace _14._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double lectures = int.Parse(Console.ReadLine());
            double bonus = int.Parse(Console.ReadLine());
            double bestMaxBonus = 0;
            double bestAttendance = 0;

            for (int i = 1; i <= students; i++)
            {
                double currentAttendances = double.Parse(Console.ReadLine());
                double currentBonus = currentAttendances / lectures * (5 + bonus);
                if (currentBonus > bestMaxBonus)
                {
                    bestMaxBonus = currentBonus;
                    bestAttendance = currentAttendances;
                }

            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(bestMaxBonus)}.");
            Console.WriteLine($"The student has attended {bestAttendance} lectures.");
        }
    }
}
