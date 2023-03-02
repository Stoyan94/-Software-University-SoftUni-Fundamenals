using System;
using System.Linq;

namespace _06.Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrItem = Console.ReadLine().
                Split().
                Select(int.Parse)
                .ToArray();

            int[] arrItem2 = Console.ReadLine().
              Split().
              Select(int.Parse)
              .ToArray();


            int sum = 0;
            bool itsSame = true;
            for (int i = 0; i < arrItem.Length; i++)
            {
                sum += arrItem2[i];
                if (arrItem[i] != arrItem2[i])
                {
                    itsSame = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            if (itsSame)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
