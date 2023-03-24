using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).
               Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string comType = cmArgs[0];

                if (comType == "Delete")
                {
                    int deleteNum = int.Parse(cmArgs[1]);
                    numbers.Remove(deleteNum);

                }
                else if (comType == "Insert")
                {
                    int numInsert = int.Parse(cmArgs[1]);
                    int indexInsert = int.Parse(cmArgs[2]);
                    numbers.Insert(indexInsert, numInsert);

                }


            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
