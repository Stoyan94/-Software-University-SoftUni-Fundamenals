using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.List_Manipolation_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            string command;

            while ((command = Console.ReadLine()) != "end")
            {

                string[] token = command.Split();
                string action = token[0];

                if (action == "Add")
                {
                    int addToken = int.Parse(token[1]);
                    numbers.Add(addToken);
                }
                else if (action == "Remove")
                {
                    int removeToken = int.Parse(token[1]);
                    numbers.Remove(removeToken);

                }
                else if (action == "RemoveAt")
                {
                    int removeAtToken = int.Parse(token[1]);
                    numbers.RemoveAt(removeAtToken);

                }
                else if (action == "Insert")
                {
                    int insertToke = int.Parse(token[1]);
                    int indexInser = int.Parse(token[2]);
                    numbers.Insert(indexInser, insertToke);

                }


            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
