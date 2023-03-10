using System;

namespace _07.Repeat_String
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            string repeat = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string final = PrintRepeat(repeat, n);
            Console.WriteLine(final);
        }

        private static string PrintRepeat(string repeat, int n)
        {
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                result += repeat;
            }
            return result;
        }
    }
}
