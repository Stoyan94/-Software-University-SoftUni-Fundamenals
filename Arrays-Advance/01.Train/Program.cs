using System;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int count = 0;
            int[] arr = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                int[] passengers = Console.ReadLine().
                 Split(" ").
                 Select(int.Parse).
                 ToArray();
                
                arr[i] = passengers[0];
                count += arr[i];
            }

            string s1 = String.Join(" ", arr);
            Console.WriteLine(String.Join(" ", arr));
            Console.WriteLine(count);
        }
    }
    
}
