using System;

namespace _01.Greater_of_Two_Values
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }

        }

        static int GetMax(int first, int seconkd)
        {
            return Math.Max(first, seconkd);
        }

        static char GetMax(char first, char seconkd)
        {
            return (first > seconkd) ? first : seconkd;
        }

        static string GetMax(string first, string seckond)
        {
            if (first.CompareTo(seckond) > 0)
                                             
            {
                return first;
            }
            else
            {
                return seckond;
            }
        }
    }
}
