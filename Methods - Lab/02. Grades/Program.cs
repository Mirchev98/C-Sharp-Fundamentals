using System;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(GradeOutput(grade));
        }

        static string GradeOutput(double grade)
        {
            string answer = string.Empty;

            if (grade < 3.00)
            {
                answer = "Fail";
            }
            else if (grade < 3.50)
            {
                answer = "Poor";
            }
            else if (grade < 4.50)
            {
                answer = "Good";
            }
            else if (grade < 5.50)
            {
                answer = "Very good";
            }
            else if(grade <= 6.00)
            {
                answer = "Excellent";
            }

            return answer;

        }
    }
}
