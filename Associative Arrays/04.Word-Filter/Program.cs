using System;
using System.Linq;

namespace _04.Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] result = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(r => r.Length % 2 == 0).ToArray();

            foreach (string s in result)
            {
                Console.WriteLine(string.Join(' ', s));

            }

        }
    }
}
