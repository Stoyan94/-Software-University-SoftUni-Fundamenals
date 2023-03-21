using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int longestList = Math.Max(firstList.Count, secondList.Count);

            List<int> result = new List<int>();

            for (int i = 0; i < longestList; i++)
            {
                if (i < firstList.Count)
                {
                    result.Add(firstList[i]);

                }
                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);

                }


            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
