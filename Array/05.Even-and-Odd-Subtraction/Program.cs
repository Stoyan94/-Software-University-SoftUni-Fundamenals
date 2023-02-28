using System;
using System.Linq;

namespace _05.Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrItem = Console.ReadLine().
                Split().
                Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;
            foreach (var item in arrItem)
            {

                if (item % 2 == 0)
                {
                    sumEven += item;
                }
                else
                {
                    sumOdd += item;
                }


            }
            int finalSum = sumEven - sumOdd;
            Console.WriteLine(String.Join(" ", finalSum));
        }
    }
}
