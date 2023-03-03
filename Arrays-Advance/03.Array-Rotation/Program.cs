using System;
using System.Linq;

namespace _03.Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayRotation = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();
            int timesRotation = int.Parse(Console.ReadLine());



            for (int j = 0; j < timesRotation; j++)
            {
                int firstEl = arrayRotation[0];
                for (int i = 0; i < arrayRotation.Length - 1; i++)
                {
                    arrayRotation[i] = arrayRotation[i + 1];

                }
                arrayRotation[arrayRotation.Length - 1] = firstEl;
            }

            Console.WriteLine(String.Join(" ", arrayRotation));
        }
    }
}
