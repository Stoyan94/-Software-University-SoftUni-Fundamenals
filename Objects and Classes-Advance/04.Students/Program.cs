using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] studentsArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentsArgs[0];
                string lastName = studentsArgs[1];
                double grade = double.Parse(studentsArgs[2]);

                Student newStudent = new Student(firstName, lastName, grade);
                students.Add(newStudent);
            }

            List<Student> orderdGrades = students.OrderByDescending
                (students => students.Grade).ToList();

            foreach (Student student in orderdGrades)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }

    }


    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }
    }
}
