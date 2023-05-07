using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {                           
            List<Cars> cars = new List<Cars>();

            int numCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split('|');

                string carModel = carInfo[0];
                int milage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);

                Cars car = new Cars(carModel,milage,fuel);

                cars.Add(car);
            }

            string input;

            while ((input=Console.ReadLine())!="Stop")
            {
                string [] commandCar = input.Split(" :",StringSplitOptions.TrimEntries);

                string command = commandCar[0];
                string carModel = commandCar[1];
                int tryMilage = int.Parse(commandCar[2]);

                Cars currCar = cars.FirstOrDefault(x => x.CarModel == carModel);

                if (command == "Drive")
                {
                    int fuelDrive = int.Parse(commandCar[3]);                   
                    currCar.Drive(tryMilage, fuelDrive,carModel,cars);            
                }
                else if (command == "Refuel")
                {
                    int refuel = int.Parse(commandCar[2]);
                    currCar.Reful(refuel);
                }
                else if (command == "Revert")
                {
                    int revertKm = int.Parse(commandCar[2]);
                    currCar.Revert(revertKm);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

       
    }
}
