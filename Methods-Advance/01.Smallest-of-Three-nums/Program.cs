using System;

namespace _01.Smallest_of_Three_nums
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());


            Console.WriteLine(ReturnkSmalletsNum(numOne, numTwo, numThree));

        }


        static int ReturnkSmalletsNum(int one, int tow, int three)
        {
            int smallestNum = int.MaxValue;

            for (int i = 1; i <= 3; i++)
            {
                if (three < smallestNum)
                {
                    smallestNum = three;
                }
                if (tow < smallestNum)
                {
                    smallestNum = tow;
                }
                if (one < smallestNum)
                {
                    smallestNum = one;
                }

            }

            return smallestNum;
        }


    }
}
