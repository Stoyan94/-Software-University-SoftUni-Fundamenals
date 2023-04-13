using System;

namespace _01.Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] searchUsername = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            bool isValidUser = true;
            char[] containtThis = new char[] { '_', '-' };

            foreach (string username in searchUsername)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    foreach (var symbol in username)
                    {
                        if (char.IsLetterOrDigit(symbol) || symbol == '_' || symbol == '-')
                        {
                            isValidUser = true;
                        }
                        else
                        {
                            isValidUser = false;
                            break;
                        }
                    }
                    if (isValidUser)
                    {
                        Console.WriteLine(username);
                    }
                }

            }
        }
    }
}
