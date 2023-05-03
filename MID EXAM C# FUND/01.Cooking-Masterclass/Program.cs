using System;

namespace _01.Cooking_Masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            double priceOneFlour = double.Parse(Console.ReadLine());
            double priceOneEgg = double.Parse(Console.ReadLine());
            double priceOneAproon = double.Parse(Console.ReadLine());

            double totalSum = priceOneFlour * (students - (students / 5));
            totalSum += (priceOneEgg * 10) * students;
            double priceAproons = priceOneAproon * Math.Ceiling(students * 1.2);

            totalSum += priceAproons;

            budget -= totalSum;

        }
    }
}
