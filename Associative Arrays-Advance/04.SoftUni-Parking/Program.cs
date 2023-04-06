using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmArgs = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
                string cmdType = cmArgs[0];
                string username = cmArgs[1];

                if (cmdType == "register")
                {
                    string licensePlateNumber = cmArgs[2];
                    RegisterUser(parkingRegister, username, licensePlateNumber);
                }
                else if (cmdType == "unregister")
                {
                    UnRegisterUser(parkingRegister, username);
                }
            }

            foreach (var kvp in parkingRegister)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }

        static void RegisterUser(Dictionary<string, string> parkingRegister, string username,
            string licensePlateNumber)
        {
            if (parkingRegister.ContainsKey(username))
            {
                string licenseNumberRegistered = parkingRegister[username];
                Console.WriteLine($"ERROR: already registered with plate number {licenseNumberRegistered}");
            }
            else
            {
                parkingRegister[username] = licensePlateNumber;
                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
            }
        }

        static void UnRegisterUser(Dictionary<string, string> parkingRegister, string username)
        {
            if (!parkingRegister.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else
            {
                Console.WriteLine($"{username} unregistered successfully");
                parkingRegister.Remove(username);

            }
        }
    }
}
