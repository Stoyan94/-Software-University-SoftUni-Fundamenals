using System;
using System.Collections.Generic;

namespace _07.Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companysInfo = new Dictionary<string, List<string>>();

            string companyNameAndUser;

            while ((companyNameAndUser = Console.ReadLine()) != "End")
            {
                string[] argsCmUser = companyNameAndUser.Split(" -> ",
                    StringSplitOptions.RemoveEmptyEntries);

                string companyName = argsCmUser[0];
                string userId = argsCmUser[1];

                if (!companysInfo.ContainsKey(companyName))
                {
                    companysInfo[companyName] = new List<string>();
                }
                if (companysInfo[companyName].Contains(userId))
                {
                    continue;
                }
                companysInfo[companyName].Add(userId);
            }

            foreach (var compName in companysInfo)
            {
                Console.WriteLine($"{compName.Key}");

                foreach (var userId in compName.Value)
                {
                    Console.WriteLine($"-- {userId}");
                }
            }
        }
    }
}
