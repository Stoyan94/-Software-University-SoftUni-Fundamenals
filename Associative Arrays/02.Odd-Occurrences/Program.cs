using System;
using System.Collections.Generic;

namespace _02.Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> occurencies = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string lowerCaseWord = word.ToLower();

                if (occurencies.ContainsKey(lowerCaseWord))
                {
                    occurencies[lowerCaseWord] += 1;
                }
                else
                {
                    occurencies.Add(lowerCaseWord, 1);
                }
            }

            foreach (var word in occurencies)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
