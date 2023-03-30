using System;

namespace _01.Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIdex = random.Next(0, words.Length);

                string currentWord = words[i];
                words[i] = words[randomIdex];
                words[randomIdex] = currentWord;

            }

            foreach (var randomIndex in words)
            {
                Console.WriteLine(randomIndex);
            }
        }
    }
}
