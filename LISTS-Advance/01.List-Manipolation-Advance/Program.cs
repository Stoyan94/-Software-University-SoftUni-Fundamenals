using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.List_Manipolation_Advance
{
    internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


        int number = 0;
        string operatorInput = string.Empty;

        bool isChanged = false;

        string commands;

        while ((commands = Console.ReadLine()) != "end")
        {
            string[] commandArg = commands.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string command = commandArg[0];

            if (commandArg.Length > 1 && commandArg.Length <= 2)
            {
                number = int.Parse(commandArg[1]);
            }
            else if (commandArg.Length > 2)
            {
                operatorInput = commandArg[1];
                number = int.Parse(commandArg[2]);
            }


            if (command == "Add")
            {
                numbers.Add(number);
                isChanged = true;
            }
            else if (command == "Remove")
            {
                numbers.Remove(number);
                isChanged = true;
            }
            else if (command == "RemoveAt")
            {
                numbers.RemoveAt(number);
                isChanged = true;
            }
            else if (command == "Insert")
            {
                int index = int.Parse(commands.Split(' ')[2]);
                numbers.Insert(index, number);
                isChanged = true;
            }
            else if(command == "Contains")
            {
                var result = numbers.Contains(number) ? number.ToString() : "No such number";
                Console.WriteLine(result);
            }
            else if (command == "PrintEven")
            {
                Console.WriteLine(string.Join(" ",numbers.Where(x => x % 2 == 0)));
            }
            else if (command == "PrintOdd")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
            }
            else if (command == "GetSum")
            {
                Console.WriteLine(numbers.Sum());
            }
            else if (command == "Filter")
            {
                switch (operatorInput)
                {
                    case ">":
                        Console.WriteLine(string.Join(" ",numbers.Where(x => x > number))); 
                        break;
                    case "<":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < number)));
                        break;
                    case ">=":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
                        break;
                    case "<=":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
                        break;
                    
                }
            }
        }

        if (isChanged)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }                
    }
  }
}
