using System;
using System.Linq;

namespace _02_Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] targets = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            string input;
            int hitTargets = 0;
            while ((input=Console.ReadLine())!="End")
            {
                int shootIndex = int.Parse(input);
                
                if (shootIndex>targets.Length-1)
                {
                    continue;                    
                }
                if (targets[shootIndex] < 0)
                {
                    continue;
                }
                hitTargets++;
                int shootedIndexValue = targets[shootIndex];
                targets[shootIndex] = -1;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] > shootedIndexValue)
                    {
                        targets[i] -= shootedIndexValue;
                    }
                    else if (targets[i] <= shootedIndexValue && targets[i] >0)
                    {
                        targets[i] += shootedIndexValue;
                    }
                }
            }

            Console.WriteLine($"Shot targets: {hitTargets} -> {string.Join(" ",targets)}");
        }
    }
}
