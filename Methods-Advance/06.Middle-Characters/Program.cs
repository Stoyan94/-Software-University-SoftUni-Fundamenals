using System;

namespace _06.Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char mid = char.MinValue;
            char midEven = char.MinValue;
            string midLetter = string.Empty;
            if (word.Length % 2 != 0)
            {
                for (int i = 0; i < word.Length / 2 + 1; i++)
                {
                    mid = word[i];

                }
                midLetter = mid.ToString();
                Console.WriteLine(midLetter);
            }
            else
            {
                for (int i = 0; i < word.Length / 2; i++)
                {
                    mid = word[i];

                    if (i == word.Length / 2 - 1)
                    {
                        midEven = word[i + 1];
                    }
                }

                midLetter = mid.ToString() + midEven.ToString();

                Console.WriteLine(midLetter);
            }


        }
    }
}
