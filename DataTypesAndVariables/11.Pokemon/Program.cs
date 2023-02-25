using System;

namespace _11.Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pokePower = int.Parse(Console.ReadLine());
            var distanceTrarget = int.Parse(Console.ReadLine());
            var exhaustion = int.Parse(Console.ReadLine());

            var targetPokeCount = 0;
            double startTarget = pokePower;

            while (pokePower >= distanceTrarget)
            {
                pokePower -= distanceTrarget;
                targetPokeCount++;
                if (startTarget / 2 == pokePower && exhaustion != 0)
                {
                    pokePower /= exhaustion;

                }

            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetPokeCount);
        }
    }
}
