using System;
using System.Collections.Generic;

namespace _02.A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> oreTypes = new Dictionary<string, int>();

            string ores;

            while ((ores = Console.ReadLine()) != "stop")
            {
                int oreAmmount = int.Parse(Console.ReadLine());

                if (oreTypes.ContainsKey(ores))
                {
                    oreTypes[ores] += oreAmmount;
                    continue;
                }

                oreTypes.Add(ores, oreAmmount);
            }

            foreach (var ore in oreTypes)
            {
                Console.WriteLine($"{ore.Key} -> {ore.Value}");
            }
        }
    }
}
