using System;
using System.Linq;

namespace _02.Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            decimal sum = 0;

            foreach (string word in words)
            {
                sum += CalculateSingleWordSum(word);
            }
            Console.WriteLine($"{sum:F2}");
        }

        static decimal CalculateSingleWordSum(string word)
        {
            decimal sum = 0;

            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int num = int.Parse(word.Substring(1, word.Length - 2));

            int firstLetterPosition = GetAlphabeticalPositionOfCharecter(firstLetter);
            int lastLetterPosition = GetAlphabeticalPositionOfCharecter(lastLetter);

            if (char.IsUpper(firstLetter))
            {
                sum = (decimal)num / firstLetterPosition;
            }
            else if (char.IsLower(firstLetter))
            {
                sum = (decimal)num * firstLetterPosition;
            }

            if (char.IsUpper(lastLetter))
            {
                sum -= lastLetterPosition;
            }
            else if (char.IsLower(lastLetter))
            {
                sum += lastLetterPosition;
            }
            return sum;
        }

        static int GetAlphabeticalPositionOfCharecter(char ch)
        {
            if (!char.IsLetter(ch))
            {
                return -1;
            }

            char chCI = char.ToLowerInvariant(ch);

            return (int)chCI - 96;
        }
    }
}
