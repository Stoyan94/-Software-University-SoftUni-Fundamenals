using System;
using System.Linq;

namespace _07.Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrItem = Console.ReadLine().
               Split().
               Select(int.Parse)
               .ToArray();

            int firstLength = arrItem.Length;

            for (int i = 0; i < firstLength - 1; i++)
            {
                int[] condese = new int[arrItem.Length - 1];

                for (int j = 0; j < arrItem.Length - 1; j++)
                {
                    condese[j] = arrItem[j] + arrItem[j + 1];
                }

                arrItem = condese;
            }

            Console.WriteLine(arrItem[0]);
        }
    }
}
