using System;

namespace _01_Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string input;

            bool isWin = true;           
            int countWins = 0;

            while ((input = Console.ReadLine()) != "End of battle")
            {
                int enemyDistance = int.Parse(input);

                if (energy < enemyDistance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countWins} won battles and {energy} energy");
                    isWin = false;
                    break;
                } 
                
                  energy -=enemyDistance;
                  countWins++;
               

                if (countWins % 3==0)
                {
                    energy += countWins;
                     
                }

               

            }

            if (isWin)
            {
                Console.WriteLine($"Won battles: {countWins}. Energy left: {energy}");
            }
            

        }
    }
}
