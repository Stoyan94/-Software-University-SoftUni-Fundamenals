using System;
using System.Linq;

namespace _02.Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstNum = new int[n];
            int[] secondNum = new int[n];

            for (int row = 1; row <= n; row++)
            {
                int[] allNums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).ToArray();

                int currNum = allNums[0];
                int currNum2 = allNums[1];

                if (row % 2 != 0)
                {
                    firstNum[row - 1] = currNum;
                    secondNum[row - 1] = currNum2;
                }
                else
                {
                    firstNum[row - 1] = currNum2;
                    secondNum[row - 1] = currNum;
                }

            }

            string outPut = String.Join(" ", firstNum);

            Console.WriteLine(String.Join(" ", firstNum));
            Console.WriteLine(String.Join(" ", secondNum));
        }
    }
}
