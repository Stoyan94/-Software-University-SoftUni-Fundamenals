using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string pattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:(\d+)[^\@\-\!\:\>]*?\!(?<atackType>[A|D]{1})\![^\@\-\!\:\>]*?\-\>(\d+)";

            int countMessages = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countMessages; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptMessage(encryptedMessage);

                Match orderInfo = Regex.Match(decryptedMessage, pattern);

                if (orderInfo.Success)
                {
                    string planet = orderInfo.Groups["planet"].Value;
                    string atackType = orderInfo.Groups["atackType"].Value;

                    if (atackType == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else if (atackType == "D")
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            PrintOutput(attackedPlanets, destroyedPlanets);
        }

        static void PrintOutput(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (string planet in attackedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (string planet in destroyedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
        static string DecryptMessage(string encryptedMessage)
        {
            StringBuilder dectyptedMessage = new StringBuilder();
            int decryptionKey = GetDecryptionKey(encryptedMessage);

            foreach (char currChar in encryptedMessage)
            {
                char decryptedCh = (char)(currChar - decryptionKey);
                dectyptedMessage.Append(decryptedCh);

            }

            return dectyptedMessage.ToString();
        }
        static int GetDecryptionKey(string encryptedMessage)
        {
            string decryptPattenr = "[start]{1}";
            MatchCollection matches =
                Regex.Matches(encryptedMessage, decryptPattenr, RegexOptions.IgnoreCase);

            return matches.Count;
        }

    }
}
