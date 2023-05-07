using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Need_for_Speed_III
{
    public class Cars
    {
        private string carModel;
        private int mileage;
        private int fuel;

        public Cars(string carName,int carMilage, int carFuel)
        {
            CarModel = carName;
            Mileage = carMilage;
            Fuel = carFuel;
            
        }

        public string CarModel { get { return this.carModel; }  set { carModel = value; } }

        public int Mileage { get { return this.mileage; } set { mileage = value; } }

        public int Fuel { get { return this.fuel; } set { fuel = value; } }

       public void Drive(int milage,int fuel,string currCar,List<Cars> allCars)
        {
            int checkMilage=  this.Mileage + milage;
            
            if (checkMilage>100000)
            {
                Cars car = allCars.Where(x => x.CarModel==currCar).FirstOrDefault();
                allCars.Remove(car);
                Console.WriteLine($"Time to sell the {currCar}!");
                return;
            }
            if (this.fuel-fuel<0)
            {
                Console.WriteLine("Not enough fuel to make that ride");
                return;
            }
            this.Mileage += milage;
            this.Fuel-=fuel;

            Console.WriteLine($"{currCar} driven for {milage} kilometers. {fuel} liters of fuel consumed.");
            
        }

        public void Reful(int refuel)
        {
            if (this.Fuel+refuel<75)
            {
                this.Fuel += refuel;
            }
            else
            {
                int fuelToAdd = 75-this.fuel;
                this.Fuel += fuelToAdd;
            }

            Console.WriteLine($"{this.carModel} refueled with {this.fuel} liters");
        }
       
        public void Revert(int km)
        {
            if (this.mileage-km<10000)
            {
                this.mileage= 10000;                
            }
            else
            {
                this.mileage-= km;
                Console.WriteLine($"{this.carModel} mileage decreased by {km} kilometers");
            }
        }

        public override string ToString()
        {
            return $"{this.carModel} -> Milage: {this.mileage} kms, Fuel in the tank: {this.Fuel} it.";
        }
    }

  
}
