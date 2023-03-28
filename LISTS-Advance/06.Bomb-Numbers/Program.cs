using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).
               Select(int.Parse).ToList();

            int[] bombInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();

            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];
           

            while (true)
            {

                int indexfOfbomb = numbers.IndexOf(bombNumber);
                if (indexfOfbomb == -1)
                {
                    break;
                }
                else
                {
                    int rightIndex = indexfOfbomb + bombPower;                                            

                    for (int countBombard = indexfOfbomb; countBombard <= rightIndex; countBombard++)
                    {
                        if (indexfOfbomb >= numbers.Count)
                        {
                            break;
                        }

                        numbers.RemoveAt(indexfOfbomb); 

                    }

                    int leftIndex = indexfOfbomb - bombPower;
                    if (leftIndex < 0) 
                    {
                        leftIndex = 0;
                    }

                    for (int leftBombard = leftIndex; leftBombard < indexfOfbomb; leftBombard++)
                    {
                        if (leftIndex >= numbers.Count)
                        {
                            break;
                        }

                        numbers.RemoveAt(leftIndex);

                    }

                }

            }
            int sum = numbers.Sum();
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
