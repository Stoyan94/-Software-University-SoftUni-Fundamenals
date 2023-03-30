using System;
using System.Collections.Generic;

namespace _05.Students_2._0
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

    }



    class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Student> students = new List<Student>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] splitParam = command.
                    Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = splitParam[0];
                string lastName = splitParam[1];
                int age = int.Parse(splitParam[2]);
                string homeTown = splitParam[3];

                bool doesStudentExist = DoesStudentExsist(students, firstName, lastName);
                if (doesStudentExist)
                {
                    Student existingStudent = GetExistingStudent(students, firstName, lastName);

                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.HomeTown = homeTown;
                }
                else
                {
                    Student newStudent = new Student(firstName, lastName, age, homeTown);

                    students.Add(newStudent);
                }


            }

            string homeTownToSearch = Console.ReadLine();

            List<Student> filteredStudents = students.FindAll(students => students.HomeTown == homeTownToSearch);

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{ student.FirstName} { student.LastName} is {student.Age } years old.");
            }
        }

        static Student GetExistingStudent(List<Student> students, string firstName,
            string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
            return null;
        }

        static bool DoesStudentExsist(List<Student> students, string firstName,
            string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
