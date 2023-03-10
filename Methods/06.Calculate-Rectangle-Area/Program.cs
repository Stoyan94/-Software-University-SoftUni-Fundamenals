using System;

namespace _06.Calculate_Rectangle_Area
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = PrintRectangle(width, height);
            Console.WriteLine(area);
        }

        static double PrintRectangle(double width, double height)
        {
            return width * height;
        }
    }
}
