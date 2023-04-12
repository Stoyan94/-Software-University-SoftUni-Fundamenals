using System;
using System.Linq;
using System.Text;

namespace _02.Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] reprint = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();
            foreach (var word in reprint)
            {
                int currWord = word.Count();

                for (int i = 0; i < currWord; i++)
                {
                    result.Append(word);
                }

            }

            Console.WriteLine(result);
        }
    }
}
