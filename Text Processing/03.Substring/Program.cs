using System;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string removedWord = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(removedWord))
            {
                int indexOfWordToRemove = text.IndexOf(removedWord);

                text = text.Remove(indexOfWordToRemove, removedWord.Length);
            }

            Console.WriteLine(text);
        }
    }
}
