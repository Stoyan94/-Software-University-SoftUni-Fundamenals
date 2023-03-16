using System;

namespace _08.Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstFactorial = long.Parse(Console.ReadLine());
            double seckondFactorial = long.Parse(Console.ReadLine()); ;

            double num1 = firstFactorial;
            double num2 = seckondFactorial;

            double finalResult = SumFactorials(firstFactorial, seckondFactorial, num1, num2);

            Console.WriteLine($"{finalResult:f2}");


        }

        static double SumFactorials(double first, double seckond, double num1, double num2)
        {
            for (double i = first - 1; i > 1; i--)
            {
                num1 = num1 * i;
            }

            for (double j = seckond - 1; j > 1; j--)
            {
                num2 = num2 * j;
            }
            double result = num1 / num2;

            return result;
        }
    }
}
