using System;
using System.Collections.Generic;

namespace _04.Students
{
    class Student
    {
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

                Student newStudent = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown
                };
                students.Add(newStudent);
            }

            string homeTownToSearch = Console.ReadLine();

            List<Student> filteredStudents = students.FindAll(students => students.HomeTown == homeTownToSearch);

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{ student.FirstName} { student.LastName} is {student.Age } years old.");
            }
        }

    }
}
