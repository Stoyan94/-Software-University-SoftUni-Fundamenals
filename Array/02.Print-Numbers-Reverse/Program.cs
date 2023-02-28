using System;

namespace _02.Print_Numbers_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] nums = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nums[i] = num;

            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {

                Console.Write($"{nums[i]} ");
            }
        }
    }
}
