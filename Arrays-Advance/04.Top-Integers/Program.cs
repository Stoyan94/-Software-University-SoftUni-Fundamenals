using System;
using System.Linq;

namespace _04.Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').
                Select(int.Parse).ToArray();

            int[] topInteger = new int[nums.Length];
            int topIntIndexes = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                int currNum = nums[i];
                bool IsTop = true;

                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    int nextNum = nums[j];

                    if (nextNum >= currNum)
                    {
                        IsTop = false;
                        break;
                    }
                }

                if (IsTop)
                {
                    topInteger[topIntIndexes] = currNum;
                    topIntIndexes++;
                }
            }

            for (int i = 0; i < topIntIndexes; i++)
            {

                Console.Write($"{topInteger[i]} ");
            }
        }
    }
}
