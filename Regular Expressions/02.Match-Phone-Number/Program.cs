using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            List<string> result = new List<string>();

            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
