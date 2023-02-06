using System;

namespace _05.Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {

                int currentNum = number * secondNum;


                Console.WriteLine($"{number} X {secondNum} = {currentNum}");
                secondNum++;
                if (secondNum > 10)
                {
                    break;
                }

            }
        }
    }
}
