using System;
using System.Collections.Generic;

namespace _04.List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfProducts = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < numOfProducts; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);

            }
            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
