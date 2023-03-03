using System;
using System.Linq;

namespace _06.Max_Sequence_of_Equal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToArray();

            int counter = 0;
            int bigest = 0;

            int longest = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (counter > bigest)
                    {
                        bigest = counter;
                        longest = numbers[i];
                    }

                }
                else
                {
                    counter = 0;
                }

            }
            for (int j = 0; j <= bigest; j++)
            {
                Console.Write($"{longest} ");
            }
        }
    }
}
