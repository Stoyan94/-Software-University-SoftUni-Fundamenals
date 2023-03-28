using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().
               Split(' ', StringSplitOptions.RemoveEmptyEntries).
               Select(int.Parse).ToList();

            List<int> seckondPlayer = Console.ReadLine().
               Split(' ', StringSplitOptions.RemoveEmptyEntries).
               Select(int.Parse).ToList();

            while (true)
            {
                if (firstPlayer[0] > seckondPlayer[0])
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(seckondPlayer[0]);

                }
                else if (seckondPlayer[0] > firstPlayer[0])
                {
                    seckondPlayer.Add(seckondPlayer[0]);
                    seckondPlayer.Add(firstPlayer[0]);
                }
                firstPlayer.Remove(firstPlayer[0]);
                seckondPlayer.Remove(seckondPlayer[0]);

                if (firstPlayer.Count == 0)
                {
                    int sum = seckondPlayer.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (seckondPlayer.Count == 0)
                {
                    int sum = firstPlayer.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
