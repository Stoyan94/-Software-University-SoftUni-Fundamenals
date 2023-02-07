using System;

namespace _02.MoreExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double totalSpent = 0;
            string gameToBuy;
            bool IsOutOfMoney = false;

            while ((gameToBuy = Console.ReadLine()) != "Game Time")
            {

                if (gameToBuy == "OutFall 4")
                {
                    if (budget < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    budget -= 39.99;
                    totalSpent += 39.99;
                    Console.WriteLine("Bought OutFall 4");
                }
                else if (gameToBuy == "CS: OG")
                {
                    if (budget < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    budget -= 15.99;
                    totalSpent += 15.99;
                    Console.WriteLine("Bought CS: OG");
                }
                else if (gameToBuy == "Zplinter Zell")
                {
                    if (budget < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    budget -= 19.99;
                    totalSpent += 19.99;
                    Console.WriteLine("Bought Zplinter Zell");
                }
                else if (gameToBuy == "Honored 2")
                {
                    if (budget < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    budget -= 59.99;
                    totalSpent += 59.99;
                    Console.WriteLine("Bought Honored 2");
                }
                else if (gameToBuy == "RoverWatch")
                {
                    if (budget < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    budget -= 29.99;
                    totalSpent += 29.99;
                    Console.WriteLine("Bought RoverWatch");
                }
                else if (gameToBuy == "RoverWatch Origins Edition")
                {
                    if (budget < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    budget -= 39.99;
                    totalSpent += 39.99;
                    Console.WriteLine("Bought RoverWatch Origins Edition");
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (budget <= 0)
                {

                    IsOutOfMoney = true;
                    break;

                }
            }

            if (!IsOutOfMoney)
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${budget:F2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
