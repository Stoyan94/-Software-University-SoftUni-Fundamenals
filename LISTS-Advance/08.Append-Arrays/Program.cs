using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();


            for (int i = items.Count - 1; i >= 0; i--)
            {
                List<string> reversedList = items[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();


                for (int j = 0; j < reversedList.Count; j++)
                {

                    Console.Write($"{reversedList[j]} ");


                }

            }
        }
    }
}
