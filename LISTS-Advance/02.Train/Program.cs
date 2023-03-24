using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengerInWagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToList();
            int maxCapacityWagon = int.Parse(Console.ReadLine());

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);


                if (cmArgs.Length > 1)
                {
                    int numAdd = int.Parse(cmArgs[1]);
                    passengerInWagons.Add(numAdd);
                    continue;

                }
                for (int i = 0; i < passengerInWagons.Count; i++)
                {
                    int currWagon = passengerInWagons[i];
                    int passEngersAdd = int.Parse(cmArgs[0]);
                    int currWagonMax = maxCapacityWagon;

                    if (passengerInWagons[i] + passEngersAdd > currWagonMax)
                    {
                        continue;
                    }
                    else
                    {
                        passengerInWagons[i] += passEngersAdd;
                        break;
                    }
                }


            }

            Console.WriteLine(String.Join(" ", passengerInWagons));
        }
    }
}
