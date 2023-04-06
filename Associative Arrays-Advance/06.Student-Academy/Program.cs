using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades[studentName] = new List<double>();
                }
                studentGrades[studentName].Add(studentGrade);


            }

            foreach (var student in studentGrades)
            {
                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
                }
            }
        }
    }
}
