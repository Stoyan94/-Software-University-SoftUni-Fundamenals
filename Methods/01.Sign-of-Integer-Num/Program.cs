﻿using System;

namespace _01.Sign_of_Integer_Num
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintNumberSign(number);
        }

        static void PrintNumberSign(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero. ");
            }

        }

    }
}
