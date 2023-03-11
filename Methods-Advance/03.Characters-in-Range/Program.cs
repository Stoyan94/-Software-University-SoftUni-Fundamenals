using System;

namespace _03.Characters_in_Range
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            PrintCharsBetween(startChar, endChar);
        }


        static char PrintCharsBetween(char startChar, char endChar)
        {
            char[] selecChars = new char[] { startChar, endChar };
            char weakChar = char.MinValue;

            if (endChar > startChar)
            {
                weakChar = char.MinValue;
                for (char i = startChar; i < endChar; i++)
                {
                    weakChar = ((char)(i + 1));
                    Console.Write($"{weakChar} ");
                    if (i + 2 == endChar)
                    {
                        break;
                    }
                    if (i + 1 == endChar)
                    {

                        break;
                    }

                }

            }
            else
            {
                int strongChar = 0;
                for (char i = endChar; i < startChar; i++)
                {
                    strongChar = (i + 1);
                    char manqk = (char)strongChar;
                    Console.Write($"{manqk} ");
                    if (i + 2 == startChar)
                    {
                        break;
                    }
                    if (i + 1 == startChar)
                    {

                        break;
                    }

                }
            }

            return weakChar;
        }

    }
}
