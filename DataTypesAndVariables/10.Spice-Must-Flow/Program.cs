using System;

namespace _10.Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint yiledSpice = uint.Parse(Console.ReadLine());
            var days = 0;
            var finalYiledSpice = 0u;
            var leftSpice = 0u;

            if (yiledSpice < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(finalYiledSpice);
            }
            else
            {
                while (yiledSpice >= 100)
                {
                    var workersConsume = 26u;
                    var lessDayProduce = 10u;

                    days++;
                    if (days > 1)
                    {
                        yiledSpice -= lessDayProduce;
                        if (yiledSpice < 100)
                        {
                            leftSpice = yiledSpice - workersConsume;
                            finalYiledSpice -= workersConsume;
                            continue;
                        }
                    }

                    leftSpice = yiledSpice - workersConsume;
                    finalYiledSpice += leftSpice;


                }
                Console.WriteLine(days - 1);
                Console.WriteLine(finalYiledSpice);

            }
        }
    }
}
