using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SoftUni_Coyrse_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ",
                StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;

            while ((command = Console.ReadLine()) != "course start")
            {
                string[] cmdArg = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string action = cmdArg[0];
                string currLesseonName = cmdArg[1];

                if (action == "Add")
                {
                    if (lessons.Contains(currLesseonName))
                    {
                        continue;
                    }
                    lessons.Add(currLesseonName);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(cmdArg[2]);

                    if (lessons.Contains(currLesseonName))
                    {
                        continue;
                    }
                    lessons.Insert(index, currLesseonName);
                }
                else if (action == "Remove")
                {
                    if (!lessons.Contains(currLesseonName))
                    {
                        continue;
                    }
                    int lessonForRemove = lessons.IndexOf(currLesseonName);
                    lessons.RemoveAt(lessonForRemove);
                    string removeExercise = $"{currLesseonName}-Exercise";
                    if (lessons.Contains(removeExercise))
                    {
                        lessons.RemoveAt(lessonForRemove + 1);
                    }
                }
                else if (action == "Swap")
                {
                    string seckondLessonSwapName = cmdArg[2];
                    if (!lessons.Contains(currLesseonName) && lessons.Contains(seckondLessonSwapName))
                    {
                        continue;
                    }
                    int indexFirstLesson = lessons.IndexOf(currLesseonName);
                    int indexSeckondLesson = lessons.IndexOf(seckondLessonSwapName);

                    SwapLessons(lessons, indexFirstLesson, indexSeckondLesson);
                }
                else if (action == "Exercise")
                {
                    string addExercise = $"{currLesseonName}-Exercise";
                    if (lessons.Contains(currLesseonName) && !lessons.Contains(addExercise))
                    {
                        int indexCurrLeson = lessons.IndexOf(currLesseonName);
                        lessons.Insert(indexCurrLeson + 1, addExercise);
                    }
                    else if (!lessons.Contains(currLesseonName))
                    {
                        lessons.Add(currLesseonName);
                        lessons.Add(addExercise);
                    }
                }
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }

            static void SwapLessons(List<string> lessons, int indexFirstLesson,
                int indexSeckondLesson)
            {
                string firstLesonName = lessons[indexFirstLesson];
                string seckonLessonName = lessons[indexSeckondLesson];

                string exercise = $"{seckonLessonName}-Exercise";

                lessons.RemoveAt(indexFirstLesson);
                lessons.Insert(indexFirstLesson, seckonLessonName);
                if (lessons.Contains(exercise))
                {
                    int indexExercise = lessons.IndexOf(exercise);
                    lessons.RemoveAt(indexExercise);
                    lessons.Insert(indexFirstLesson + 1, exercise);
                    indexSeckondLesson++;
                }

                lessons.RemoveAt(indexSeckondLesson);
                lessons.Insert(indexSeckondLesson, firstLesonName);
            }
        }
    }

} 



