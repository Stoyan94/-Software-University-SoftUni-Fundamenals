using System;
using System.Linq;
using System.Text;

namespace Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;


            while ((word = Console.ReadLine()) != "end")
            {
                char[] revers = word.Reverse().ToArray();
                StringBuilder sb = new StringBuilder();

                sb.Append(revers);

                Console.WriteLine($"{word} = {sb}");
            }
        }
    }
}
