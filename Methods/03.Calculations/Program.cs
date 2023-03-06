using System;

namespace _03.Calculations
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    PrintAdd(num1, num2);
                    break;
                case "multiply":
                    PrintMultiply(num1, num2);
                    break;
                case "subtract":
                    PrintSubtrac(num1, num2);
                    break;
                case "divide":
                    PrintDevide(num1, num2);
                    break;
            }

        }

        static void PrintAdd(int num1, int num2)
        {
            Console.WriteLine($"{num1 + num2}");

        }

        static void PrintMultiply(int num1, int num2)
        {
            Console.WriteLine($"{num1 * num2}");

        }

        static void PrintSubtrac(int num1, int num2)
        {
            Console.WriteLine($"{num1 - num2}");

        }

        static void PrintDevide(int num1, int num2)
        {
            Console.WriteLine($"{num1 / num2}");
        }
    }
}
