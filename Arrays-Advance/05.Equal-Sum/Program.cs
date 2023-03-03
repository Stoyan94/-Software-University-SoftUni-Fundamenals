using System;
using System.Linq;

namespace _05.Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').
              Select(int.Parse).ToArray();
            bool isEqual = false;

            for (int i = 0; i < num.Length; i++)
            {
                int leftSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftSum += num[k];
                }
                int rightSum = 0;
                for (int j = num.Length - 1; j > i; j--)
                {
                    rightSum += num[j];

                }
                if (leftSum == rightSum)
                {
                    isEqual = true;
                    Console.WriteLine(i);

                }

            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
