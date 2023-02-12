using System;

namespace _07.Triples_of_LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int latin = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + latin; i++)
            {

                for (char k = 'a'; k < 'a' + latin; k++)
                {


                    for (char l = 'a'; l < 'a' + latin; l++)
                    {


                        Console.WriteLine($"{i}{k}{l}");
                    }

                }

            }
        }
    }
}
