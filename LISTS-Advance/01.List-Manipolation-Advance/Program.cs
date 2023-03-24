using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.List_Manipolation_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool isChange = false;
            string command;

            while ((command = Console.ReadLine()) != "end")
            {

                string[] token = command.Split();
                string action = token[0];

                if (action == "Add")
                {
                    int addToken = int.Parse(token[1]);
                    numbers.Add(addToken);
                    isChange = true;
                }
                else if (action == "Remove")
                {
                    int removeToken = int.Parse(token[1]);
                    numbers.Remove(removeToken);
                    isChange = true;

                }
                else if (action == "RemoveAt")
                {
                    int removeAtToken = int.Parse(token[1]);
                    numbers.RemoveAt(removeAtToken);
                    isChange = true;

                }
                else if (action == "Insert")
                {
                    int insertToke = int.Parse(token[1]);
                    int indexInser = int.Parse(token[2]);
                    numbers.Insert(indexInser, insertToke);
                    isChange = true;

                }
                else if (action == "Contains")
                {
                    int containsToke = int.Parse(token[1]);
                    if (numbers.Contains(containsToke))
                    {
                        Console.WriteLine("Yes");

                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }

                }
                else if (action == "PrintEven")
                {
                    List<int> even = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(String.Join(" ", even));
                }
                else if (action == "PrintOdd")
                {
                    List<int> odd = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(String.Join(" ", odd));
                }
                else if (action == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(String.Join(" ", sum));
                }
                else if (action == "Filter")
                {
                    string toke = token[1];
                    int numberForComper = int.Parse(token[2]);
                    List<int> result = new List<int>();
                    switch (toke)
                    {
                        case "<":
                            result = numbers.FindAll(x => x < numberForComper);
                            break;
                        case ">":
                            result = numbers.FindAll(x => x > numberForComper);
                            break;
                        case ">=":
                            result = numbers.FindAll(x => x >= numberForComper);
                            break;
                        case "<=":
                            result = numbers.FindAll(x => x <= numberForComper);
                            break;

                    }
                    Console.WriteLine(String.Join(" ", result));
                }


            }

            if (isChange)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }

        }
    }
}
