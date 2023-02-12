using System;

namespace _09.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //currentVolume 3.14 * radius * radius * heigh

            var numOfKegs = int.Parse(Console.ReadLine());
            string numOfKeg = String.Empty;


            var biggestKeg = 0.0;
            for (int i = 1; i <= numOfKegs; i++)
            {
                var typeBeerKeg = Console.ReadLine();
                var radius = float.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                var currentVolumes = Math.PI * Math.Pow(radius, 2) * height;


                if (currentVolumes > biggestKeg)
                {
                    biggestKeg = currentVolumes;
                    numOfKeg = typeBeerKeg;
                }

            }

            Console.WriteLine(numOfKeg);
        }
    }
}
