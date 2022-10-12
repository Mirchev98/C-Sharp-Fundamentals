using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideOne = int.Parse(Console.ReadLine());
            int sideTwo = int.Parse(Console.ReadLine());

            AreaFinder(sideOne, sideTwo);
        }

        static double AreaFinder(int sideOne, int sideTwo)
        {
            double area = sideOne * sideTwo;
            Console.WriteLine(area);
            return area;
        }
    }
}
