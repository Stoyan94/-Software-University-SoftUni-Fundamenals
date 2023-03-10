using System;

namespace _05.Orders
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            double orderPrice = double.Parse(Console.ReadLine());
            PriceOrder(order, orderPrice);
        }

        static void PriceOrder(string order, double price)
        {
            if (order == "coffee")
            {
                price *= 1.50;
            }
            else if (order == "water")
            {
                price *= 1.00;
            }
            else if (order == "coke")
            {
                price *= 1.40;
            }
            else if (order == "snacks")
            {
                price *= 2.00;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
