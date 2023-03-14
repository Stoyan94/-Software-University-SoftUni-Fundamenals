using System;

namespace _04.Paswword_Validator
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            const int minLenght = 6;
            const int maxLenght = 10;
            const int minDigit = 2;
            string password = Console.ReadLine();

            bool isPasswordValide = ValidPassword(password, minLenght, maxLenght, minDigit);

            if (isPasswordValide)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ValidPassword(string password, int minLenght, int maxLenght, int minDigit)
        {
            bool IspasswordValide = true;

            if (!ValidatePasswordLenght(password, minLenght, maxLenght))
            {
                Console.WriteLine($"Password must be between {minLenght} and {maxLenght} characters");
                IspasswordValide = false;
            }

            if (!ValidatePaswwrodAplhaNumerical(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                IspasswordValide = false;
            }

            if (!ValidatePasswordMinrDigit(password, minDigit))
            {
                Console.WriteLine($"Password must have at least {minDigit} digits");
                return false;
            }

            return IspasswordValide;

        }

        static bool ValidatePasswordLenght(string password, int minLeght, int maxLenght)
        {
            if (password.Length >= minLeght & password.Length <= maxLenght)
            {
                return true;
            }
            return false;
        }

        static bool ValidatePasswordMinrDigit(string password, int minDigit)
        {
            int countDigit = 0;
            foreach (char item in password)
            {
                if (Char.IsDigit(item))
                {
                    countDigit++;
                }


            }
            return countDigit >= minDigit; ;
        }

        static bool ValidatePaswwrodAplhaNumerical(string password)
        {
            foreach (char item in password)
            {
                if (!Char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
