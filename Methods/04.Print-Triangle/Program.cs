using System;

namespace _04.Print_Triangle
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i < height; i++)
            {
                PrinUpLine(1, i);

            }
            for (int j = height; j >= 1; j--)
            {
                PrinUpLine(1, j);
            }

        }

        static void PrinUpLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");

            }
            Console.WriteLine();
        }
    }
}
