using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Store_Boxes
{
    class Box
    {

        public string SerialNum { get; set; }

        public string BoxItemName { get; set; }

        public double BoxItemQuantity { get; set; }

        public double PriceForBox { get; set; }

        public double FinalPrice { get; set; }


    }


    class Program
    {
        static void Main(string[] args)
        {

            string input;
            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokes = input.Split(' ');

                string boxSerialNum = tokes[0];
                string boxItemName = tokes[1];
                int boxItemPrice = int.Parse(tokes[2]);
                double boxItemQuantity = double.Parse(tokes[3]);
                double finalPrice = boxItemPrice * boxItemQuantity;

                Box box = new Box()
                {
                    SerialNum = boxSerialNum,
                    BoxItemName = boxItemName,
                    BoxItemQuantity = boxItemQuantity,
                    PriceForBox = boxItemPrice,
                    FinalPrice = finalPrice

                };
                boxes.Add(box);

            }

            List<Box> orderBox = boxes.OrderByDescending(boxes => boxes.FinalPrice).ToList();

            foreach (Box item in orderBox)
            {
                Console.WriteLine($"{item.SerialNum}");
                Console.WriteLine($"-- {item.BoxItemName} - ${item.BoxItemQuantity:F2}: {item.PriceForBox}");
                Console.WriteLine($"-- ${item.FinalPrice:F2}");
            }           

        }

    }
}