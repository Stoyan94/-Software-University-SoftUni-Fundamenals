using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().
                 Split(' ', StringSplitOptions.RemoveEmptyEntries).
                 ToList();

            string command;

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmType = cmArgs[0];

                if (cmType == "merge")
                {
                    int startIndex = int.Parse(cmArgs[1]);
                    int endIndex = int.Parse(cmArgs[2]);

                    Merge(words, startIndex, endIndex);
                }
                else if (cmType == "divide")
                {
                    int index = int.Parse(cmArgs[1]);
                    int partitionsCount = int.Parse(cmArgs[2]);

                    Divide(words, index, partitionsCount);
                }
            }

            Console.WriteLine(String.Join(' ', words));

        }

        static void Merge(List<string> words, int startIndex, int endIndex)
        {
            if (!IsIndexValid(words, startIndex))
            {
                startIndex = 0;
            }

            if (!IsIndexValid(words, endIndex))
            {
                endIndex = words.Count - 1;
            }

            StringBuilder merged = new StringBuilder();  

            for (int i = startIndex; i <= endIndex; i++)
            {
                merged.Append(words[startIndex]);
                words.RemoveAt(startIndex);
            }

            words.Insert(startIndex, merged.ToString());
        }

        static void Divide(List<string> words, int elementIndex, int partitionsCount)
        {
            string word = words[elementIndex];

            if (partitionsCount > word.Length) 
            {
                return;
            }

            int partitionsLeng = word.Length / partitionsCount;
            int partitionsLeft = word.Length % partitionsCount;
            int lastPartitionsLenght = partitionsLeng + partitionsLeft;

            List<string> partitons = new List<string>();

            for (int i = 0; i < partitionsCount; i++)
            {
                char[] currentPartitions;

                if (i == partitionsCount - 1)
                {
                    currentPartitions = word.
                        Skip(i * partitionsLeng)
                        .Take(lastPartitionsLenght)
                        .ToArray();
                }
                else
                {
                    currentPartitions = word
                        .Skip(i * partitionsLeng)
                        .Take(partitionsLeng)
                        .ToArray();
                }
                partitons.Add(new string(currentPartitions));
            }

            words.RemoveAt(elementIndex);
            words.InsertRange(elementIndex, partitons);

        }

        private static void Skip()
        {
            throw new NotImplementedException();
        }

        static bool IsIndexValid(List<string> words, int index)
        {
            return index >= 0 && index < words.Count;
        }
    }
}
