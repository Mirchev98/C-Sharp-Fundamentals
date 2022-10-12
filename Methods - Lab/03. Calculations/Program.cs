using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(Calcuilations(action, firstNum, secondNum));
        }

        static int Calcuilations(string action, int firstNum, int secondNum)
        {
            int sum = 0;

            if (action == "add")
            {
                sum = firstNum + secondNum;
            }
            else if(action == "multiply")
            {
                sum = firstNum * secondNum;
            }
            else if (action == "substract")
            {
                sum = firstNum - secondNum;
            }
            else if (action == "divide")
            {
                sum = firstNum / secondNum;
            }

            return sum;
        }
    }
}
