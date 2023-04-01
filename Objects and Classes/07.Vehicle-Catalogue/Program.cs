using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Vehicle_Catalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalogObject = new Catalog();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] token = input.Split('/');

                string type = token[0];
                string brand = token[1];
                string model = token[2];
                int finalParam = int.Parse(token[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, finalParam);
                    catalogObject.Cars.Add(newCar);
                }
                else if (type == "Truck")
                {
                    Truck newTrucks = new Truck(brand, model, finalParam);
                    catalogObject.Trucks.Add(newTrucks);
                }
            }

            if (catalogObject.Cars.Count > 0)
            {
                List<Car> orderedCars = catalogObject.Cars.OrderBy(car => car.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (Car car in orderedCars)
                {

                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalogObject.Trucks.Count > 0)
            {
                List<Truck> orderedTrcuks = catalogObject.Trucks.OrderBy(truck => truck.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderedTrcuks)
                {

                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }



    }
}
