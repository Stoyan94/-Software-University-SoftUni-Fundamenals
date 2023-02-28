using System;
using System.Linq;

namespace _04.Sum_Even_Nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrItem = Console.ReadLine().
               Split().
               Select(int.Parse)
               .ToArray();

            int sum = 0;
            foreach (var item in arrItem)
            {

                if (item % 2 == 0)
                {
                    sum += item;
                }

            }
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
