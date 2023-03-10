using System;

namespace _08.Math_Power
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double powerNum = double.Parse(Console.ReadLine());
            double powerdNum = PrintRepeat(baseNum, powerNum);
            Console.WriteLine(powerdNum);
        }

        static double PrintRepeat(double baseNum, double PowerNUm)
        {
            return Math.Pow(baseNum, PowerNUm);

        }
    }
}
