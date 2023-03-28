using System;
using System.Collections.Generic;

namespace _03.House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();

            int n = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < n; i++)
            {
                string[] cmArgs = Console.ReadLine().
                    Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = cmArgs[0]; 

                if (cmArgs.Length == 3)
                {

                    if (guestList.Contains(name)) 
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    guestList.Add(name);
                }
                else if (cmArgs.Length == 4) 
                {
                    if (!guestList.Contains(name)) 
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    guestList.Remove(name);
                }


            }

            for (int j = 0; j < guestList.Count; j++)
            {
                Console.WriteLine(guestList[j]);
            }
        }
    }
}
