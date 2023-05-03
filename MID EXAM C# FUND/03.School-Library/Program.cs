using System;
using System.Linq;
using System.Collections.Generic;


namespace TrainingGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shelfBooks = Console.ReadLine().Split("&",
                StringSplitOptions.RemoveEmptyEntries).ToList();

            string moventBooks;

            while ((moventBooks = Console.ReadLine()) != "Done")
            {
                string[] moventArgs = moventBooks.Split("|", StringSplitOptions.TrimEntries);

                string action = moventArgs[0];

                if (action == "Add Book")
                {
                    string bookName = moventArgs[1];
                    if (shelfBooks.Contains(bookName))
                    {
                        continue;
                    }
                    shelfBooks.Insert(0, bookName);
                }
                else if (action == "Take Book")
                {
                    string bookName = moventArgs[1];
                    if (!shelfBooks.Contains(bookName))
                    {
                        continue;
                    }
                    shelfBooks.Remove(bookName);
                }
                else if (action == "Swap Books")
                {
                    string firstBookName = moventArgs[1];
                    string seckBookName = moventArgs[2];

                    if (!shelfBooks.Contains(firstBookName) || !shelfBooks.Contains(seckBookName))
                    {
                        continue;
                    }
                    SwapBooks(shelfBooks, firstBookName, seckBookName);
                }
                else if (action == "Insert Book")
                {
                    string bookNme = moventArgs[1];
                    if (shelfBooks.Contains(bookNme))
                    {
                        continue;
                    }
                    shelfBooks.Add(bookNme);
                }
                else if (action == "Check Book")
                {
                    int chekIndexForBook = int.Parse(moventArgs[1]);

                    if (chekIndexForBook < 0 && chekIndexForBook > shelfBooks.Count)
                    {
                        continue;
                    }
                    Console.WriteLine($"{shelfBooks[chekIndexForBook]}");
                }
            }
            Console.WriteLine(string.Join(", ", shelfBooks));
        }

        static void SwapBooks(List<string> shelfBooks, string firstBookName, string seckBookName)
        {
            int indexFirstBook = shelfBooks.IndexOf(firstBookName);
            int indexSecBook = shelfBooks.IndexOf(seckBookName);
            shelfBooks.RemoveAt(indexFirstBook);
            shelfBooks.Insert(indexFirstBook, seckBookName);
            shelfBooks.RemoveAt(indexSecBook);
            shelfBooks.Insert(indexSecBook, firstBookName);
        }
    }
}

