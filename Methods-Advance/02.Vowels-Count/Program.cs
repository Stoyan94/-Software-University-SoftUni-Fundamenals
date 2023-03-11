using System;
using System.Linq;

namespace _02.Vowels_Count
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Console.WriteLine(VowelsCoutn(word));
        }

        static int VowelsCoutn(string countVwoels)
        {
            int vowelsCount = 0;
            char[] vowelsS = new char[] { 'a', 'e', 'i', 'o', 'u' };

            foreach (char ch in countVwoels.ToLower())
            {
                if (vowelsS.Contains(ch))
                {
                    vowelsCount++;
                }

            }

            return vowelsCount;
        }
    }
}
