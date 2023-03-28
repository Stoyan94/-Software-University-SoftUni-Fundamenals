using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.List_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmType = cmArgs[0];

                if (cmType == "Add")
                {
                    int numAdd = int.Parse(cmArgs[1]);
                    numbers.Add(numAdd);
                }
                else if (cmType == "Insert")
                {
                    int insertNum = int.Parse(cmArgs[1]);
                    int insertIndex = int.Parse(cmArgs[2]);

                    if (insertIndex >= numbers.Count || insertIndex < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(insertIndex, insertNum);

                }
                else if (cmType == "Remove")
                {
                    int removeIndex = int.Parse(cmArgs[1]);

                    if (removeIndex >= numbers.Count || removeIndex < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(removeIndex);
                }
                else if (cmType == "Shift")
                {
                    string direction = cmArgs[1];
                    int countShift = int.Parse(cmArgs[2]);
                    int realPerformedCount = countShift % numbers.Count;  

                    if (direction == "left")
                    {
                        for (int i = 1; i <= realPerformedCount; i++)
                        {

                            int firstElemt = numbers.First();
                            numbers.Remove(firstElemt); 
                            numbers.Add(firstElemt); 

                        }

                    }
                    else if (direction == "right")
                    {
                        for (int i = 1; i <= realPerformedCount; i++)
                        {
 
                            int lastElement = numbers.Last();
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastElement);
                        }
                    }
                }


            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
