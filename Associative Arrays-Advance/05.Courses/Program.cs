using System;
using System.Collections.Generic;

namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfoSave = new Dictionary<string, List<string>>();

            string courseInfoProces;

            while ((courseInfoProces = Console.ReadLine()) != "end")
            {
                string[] argsCursuInfo = courseInfoProces.Split(" : ",
                    StringSplitOptions.RemoveEmptyEntries);

                string courseName = argsCursuInfo[0];
                string studentName = argsCursuInfo[1];

                if (!courseInfoSave.ContainsKey(courseName))
                {
                    courseInfoSave[courseName] = new List<string>();
                }
                courseInfoSave[courseName].Add(studentName);


            }

            foreach (var courseName in courseInfoSave)
            {
                Console.WriteLine($"{courseName.Key}: {courseName.Value.Count}");

                foreach (var studentName in courseName.Value)
                {
                    Console.WriteLine($"-- {string.Join(" ", studentName)}");
                }
            }
        }
    }
}
