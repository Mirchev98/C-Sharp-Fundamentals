using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());

            int sum = Sum(one, two);
            int result = Result(sum, three);
            Console.WriteLine(result);
        }


        static int Sum(int one, int two)
        {
            int sum = one + two;
            return sum;
        }
        static int Result(int sum, int three)
        {
            int result = sum - three;
            return result;
        }
    }
}
