﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Remove_Negatives_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.RemoveAll(x => x < 0);
            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
