using System;

namespace _06.PrintPartOf_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int asci = int.Parse(Console.ReadLine());
            int asci2 = int.Parse(Console.ReadLine());

            for (int i = asci; i <= asci2; i++)
            {

                char currentChar = (char)i;

                Console.Write($"{currentChar} ");
            }
        }
    }
}
