using System;
using System.Linq;

namespace _02.Lady_Bugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldLenght = int.Parse(Console.ReadLine()); 
            int[] ladybugsIndex = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();  

            int[] field = new int[fieldLenght];
          
            for (int inedxField = 0; inedxField < fieldLenght; inedxField++)
            {
                if (ladybugsIndex.Contains(inedxField))
                {
                    field[inedxField] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {

                string[] comArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).
                    ToArray();


                int initialIndex = int.Parse(comArgs[0]);
                string direction = comArgs[1];
                int flyLenght = int.Parse(comArgs[2]);


                if (initialIndex < 0 || initialIndex >= fieldLenght)
                {

                    continue;
                }

                if (field[initialIndex] == 0)
                {
                    continue;

                }

                field[initialIndex] = 0;
                int nextIndex = initialIndex;


                while (true)
                {
                    if (direction == "right")

                    {
                        nextIndex += flyLenght;
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= flyLenght;
                    }


                    if (nextIndex < 0 || nextIndex >= fieldLenght)
                    {
                        break;
                    }
                    if (field[nextIndex] == 0)
                    {
                        break;
                    }

                }

                if (nextIndex >= 0 && nextIndex < fieldLenght)
                {
                    field[nextIndex] = 1;
                }

            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
