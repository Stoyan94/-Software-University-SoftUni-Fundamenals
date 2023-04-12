using System;
using System.Text;

namespace _05.Digits_Letters_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder letter = new StringBuilder();
            StringBuilder numbers = new StringBuilder();
            StringBuilder charecters = new StringBuilder();
            string text = Console.ReadLine();

            foreach (var item in text)
            {
                if (char.IsLetter(item))
                {
                    letter.Append(item);
                }
                else if (char.IsDigit(item))
                {
                    numbers.Append(item);
                }
                else
                {
                    charecters.Append(item);
                }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letter);
            Console.WriteLine(charecters);
        }
    }
}
