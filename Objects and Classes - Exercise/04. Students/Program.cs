using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < students; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                Student student = new Student(tokens[0], tokens[1], double.Parse(tokens[2]));
                studentsList.Add(student);
            }

            List<Student> orderedStudents = studentsList.OrderByDescending(x => x.Grade).ToList();

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
