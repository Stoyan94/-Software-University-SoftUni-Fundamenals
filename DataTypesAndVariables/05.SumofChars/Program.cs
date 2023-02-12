using System;

namespace _05.SumofChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char currChar = char.Parse(Console.ReadLine());
                int numChar = (int)currChar;

                sum += numChar;

            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
