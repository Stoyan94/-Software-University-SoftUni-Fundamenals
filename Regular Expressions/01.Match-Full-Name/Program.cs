using System;
using System.Text.RegularExpressions;

namespace _01.Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pater = @"\b([A-Z][a-z]{1,}) ([A-Z][a-z]{1,})\b";

            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pater);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
