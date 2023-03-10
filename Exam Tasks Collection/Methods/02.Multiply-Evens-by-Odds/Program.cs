using System;

namespace _02.Multiply_Evens_by_Odds
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var sumEven = GetSumOfEvenDigit(number);
            var sumOdd = GetSumOfOddDigit(number);
            Console.WriteLine(sumEven * sumOdd);


        }

        static int GetSumOfEvenDigit(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = Math.Abs(number % 10);
                if (digit % 2 == 0)
                {
                    sum += number % 10;
                }
                number /= 10;

            }

            return sum;
        }

        static int GetSumOfOddDigit(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = Math.Abs(number % 10);
                if (digit % 2 != 0)
                {
                    sum += number % 10;
                }
                number /= 10;

            }

            return sum;
        }

    }
}
