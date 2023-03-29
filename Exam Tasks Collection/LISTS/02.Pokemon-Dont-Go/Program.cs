using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Pokemon_Dont_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonDistance = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> SumValue = new List<int>();

            while (pokemonDistance.Count != 0)
            {

                int pokemonIndexCaptured = int.Parse(Console.ReadLine());


                if (pokemonIndexCaptured >= 0 && pokemonIndexCaptured < pokemonDistance.Count)
                {
                    CapturePokemon(pokemonDistance, pokemonIndexCaptured, SumValue);
                }
                else if (pokemonIndexCaptured >= pokemonDistance.Count)
                {
                    int firstIndex = pokemonDistance.First();


                    pokemonDistance.Add(firstIndex);
                    pokemonIndexCaptured = pokemonDistance.Count - 2;
                    CapturePokemon(pokemonDistance, pokemonIndexCaptured, SumValue);
                    continue;
                }
                else if (pokemonIndexCaptured < 0)
                {
                    int LastIndex = pokemonDistance.Last();


                    pokemonDistance.Insert(0, LastIndex);
                    pokemonIndexCaptured = 1;
                    CapturePokemon(pokemonDistance, pokemonIndexCaptured, SumValue);
                    continue;
                }

            }

            Console.WriteLine(SumValue.Sum());

        }

        static List<int> CapturePokemon(List<int> pokemonIndexes, int pokemonIndex, List<int> SumValue)
        {

            int pokemonDistanceValue = pokemonIndexes[pokemonIndex];
            pokemonIndexes.RemoveAt(pokemonIndex);


            for (int i = 0; i < pokemonIndexes.Count; i++)
            {
                if (pokemonDistanceValue >= pokemonIndexes[i])
                {
                    pokemonIndexes[i] += pokemonDistanceValue;
                }
                else
                {
                    pokemonIndexes[i] -= pokemonDistanceValue;
                }
            }
            SumValue.Add(pokemonDistanceValue);

            return pokemonIndexes;
        }

    }
}
