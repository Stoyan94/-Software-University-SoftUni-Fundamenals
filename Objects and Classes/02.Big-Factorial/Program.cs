using System;
using System.Numerics;

namespace _02.Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = int.Parse(Console.ReadLine());

            BigInteger Bigfactorial = 1;
            for (int i = 1; i <= number; i++)
            {
                Bigfactorial = Bigfactorial * i;
            }

            Console.WriteLine(Bigfactorial);
        }
    }
}
