using System;

namespace _03.Foreign_Languagrs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string leangueSpeak = Console.ReadLine();


            switch (leangueSpeak)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico": Console.WriteLine("Spanish"); break;
                default: Console.WriteLine("unknown"); break;

            }
        }
    }
}
