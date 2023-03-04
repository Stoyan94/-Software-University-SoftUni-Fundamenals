using System;
using System.Linq;

namespace _07.Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').
               Select(int.Parse).ToArray();

            int givenNum = int.Parse(Console.ReadLine());
            bool isSpecial = false;
            for (int i = 0; i < num.Length; i++)
            {
                int firstDigit = 0;
                firstDigit = num[i];

                for (int j = i + 1; j < num.Length; j++)
                {
                    int secondDigit = 0;
                    secondDigit = num[j];
                    if (firstDigit + secondDigit == givenNum)
                    {
                        Console.WriteLine($"{firstDigit} {secondDigit}");

                    }

                }

            }
        }
    }
}
