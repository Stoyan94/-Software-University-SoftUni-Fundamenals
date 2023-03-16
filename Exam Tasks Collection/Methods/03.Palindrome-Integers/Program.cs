using System;

namespace _03.Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                bool itPalindrome = IsPalindrome(input);
                if (itPalindrome)
                {
                    Console.WriteLine("true");
                }
                if (!itPalindrome)
                {
                    Console.WriteLine("false");
                }
            }

        }

        static bool IsPalindrome(string input)
        {
            int number = int.Parse(input);

            bool result = false;
            if (number >= 0 && number <= 9)
            {
                result = true;
            }
            else
            {
                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (input[i] == input[input.Length - 1])
                    {
                        result = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return result;
        }
    }
}
