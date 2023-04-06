using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Chars_in_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (var item in text.ToCharArray())
            {
                if (!charCount.ContainsKey(item))
                {
                    charCount[item] = 0;
                }
                charCount[item] += 1;
            }

            foreach (var item in charCount.Where(charCount => charCount.Key != ' '))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
