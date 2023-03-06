using System;
using System.Linq;

namespace _01.Encrypt_Sort_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numNames = int.Parse(Console.ReadLine());

            char[] vowel = new char[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };


            int[] output = new int[numNames];

            for (int i = 0; i <= numNames - 1; i++)
            {
                string input = Console.ReadLine();
                int consonantSum = 0;
                int sumAplhabet = 0;
                int vowelsSum = 0;

                foreach (var item in input)
                {
                    if (vowel.Contains(item))
                    {
                        vowelsSum += (int)item * input.Length;
                    }
                    else
                    {
                        consonantSum += (int)item / input.Length;
                    }

                }
                sumAplhabet += vowelsSum + consonantSum;

                output[i] += sumAplhabet;
            }

            Array.Sort(output);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
