using System;

namespace _08.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var timesPour = int.Parse(Console.ReadLine());

            var capacity = 255;
            var sumCapacity = 0;

            for (int i = 0; i < timesPour; i++)
            {
                var waterQuantites = int.Parse(Console.ReadLine());

                sumCapacity += waterQuantites;
                if (sumCapacity > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumCapacity -= waterQuantites;
                    continue;
                }

            }
            Console.WriteLine(sumCapacity);
        }
    }
}
