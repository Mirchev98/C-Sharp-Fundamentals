using System;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int numTwo = int.Parse(Console.ReadLine());


            switch (@operator)
            {
                case "/":
                    Console.WriteLine(Divider(numOne, numTwo));
                    break;
                case "*":
                    Console.WriteLine(Multiplier(numOne, numTwo));
                    break;
                case "+":
                    Console.WriteLine(Collection(numOne, numTwo));
                    break;
                case "-":
                    Console.WriteLine(Minus(numOne, numTwo));
                    break;

            }
        }

        static int Minus(int numOne, int numTwo)
        {
            int result = numOne - numTwo;
            return result;
        }

        static int Multiplier(int numOne, int numTwo)
        {
            int result = numOne * numTwo;
            return result;
        }

        static int Divider(int numOne, int numTwo)
        {
            int result = numOne / numTwo;
            return result;
        }
        static int Collection(int numOne, int numTwo)
        {
            int result = numOne + numTwo;
            return result;
        }

    }
}
