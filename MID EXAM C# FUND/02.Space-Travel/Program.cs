using System;


namespace TrainingGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commands = Console.ReadLine();
            int mySpaceShipFuel = int.Parse(Console.ReadLine());
            int ammAmount = int.Parse(Console.ReadLine());

            string[] cmdArgs = commands.Split("||");

            for (int i = 0; i < cmdArgs.Length; i++)
            {
                string[] splitArs = cmdArgs[i].Split(" ");

                string action = splitArs[0];
                if (action == "Travel")
                {
                    int fuelConsume = int.Parse(splitArs[1]);
                    if (fuelConsume > mySpaceShipFuel)
                    {
                        Console.WriteLine("Mission Faild");
                        break;
                    }
                    mySpaceShipFuel -= fuelConsume;
                    Console.WriteLine($"The spaceship travelled {fuelConsume} light-years");
                }
                else if (action == "Enemy")
                {
                    int enemyArmour = int.Parse(splitArs[1]);
                    if (enemyArmour > ammAmount)
                    {
                        mySpaceShipFuel -= (enemyArmour * 2);
                        if (mySpaceShipFuel < 0)
                        {
                            Console.WriteLine("Mission faild");
                            break;
                        }
                        Console.WriteLine($"An enemy with {enemyArmour} is  outmaneurved");
                    }
                    else
                    {
                        ammAmount -= enemyArmour;
                        Console.WriteLine($"An enemy with {enemyArmour} is defeted");
                    }

                }
                else if (action == "Repair")
                {
                    int addetFuel = int.Parse(splitArs[1]);
                    int addetAmmno = addetFuel * 2;
                    mySpaceShipFuel += addetFuel;
                    ammAmount += addetAmmno;

                    Console.WriteLine($"Ammunitions added:{addetAmmno}");
                    Console.WriteLine($"Fuel added:{addetFuel}");
                }
                else if (action == "Titan")
                {
                    Console.WriteLine("Titan reached");
                }
            }
            Console.WriteLine();


        }
    }
}

