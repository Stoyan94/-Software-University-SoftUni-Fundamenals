using System;

namespace _05.Add_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int seckondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int sumNumbers = SumFirstAndSeckond(firstNum, seckondNum);
            int substratedNum = SubstractSumDigits(sumNumbers, thirdNum);

            Console.WriteLine(substratedNum);

        }

        static int SumFirstAndSeckond(int firstNum, int seckondNum)
        {
            return firstNum + seckondNum;
        }

        static int SubstractSumDigits(int sumNums, int substratNum)
        {
            return sumNums - substratNum;

        }
    }
}
