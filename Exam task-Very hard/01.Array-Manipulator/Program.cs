using System;
using System.Linq;

namespace _01.Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().
                Split(' ').Select(int.Parse).
                ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmArgs = command.Split(' ');

                string commandType = cmArgs[0];

                if (commandType == "exchange")
                {
                    int exchangeIndex = int.Parse(cmArgs[1]); 

                    if (exchangeIndex < 0 || exchangeIndex >= numbers.Length) 
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers = ExchangeArrayParts(numbers, exchangeIndex);
                }

                else if (commandType == "max")
                {
                    string oddOrEven = cmArgs[1];

                    int maxIndex = MaxElementOfTypeIndex(numbers, oddOrEven);

                    if (maxIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxIndex);
                    }
                }
                else if (commandType == "min")
                {
                    string oddOrEven = cmArgs[1];

                    int minIndex = MinElementOfTypeIndex(numbers, oddOrEven);
                    if (minIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minIndex);
                    }
                }
                else if (commandType == "first" || commandType == "last")
                {
                    int count = int.Parse(cmArgs[1]);
                    string oddOrEven = cmArgs[2];

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (commandType == "first")
                    {
                        PrintFirstElementOfType(numbers, count, oddOrEven);
                    }
                    else
                    {
                        PrintLastElementOfType(numbers, count, oddOrEven);
                    }

                }

            }
            Console.WriteLine(ArrayToStringFormat(numbers, numbers.Length));
        }

        static int[] ExchangeArrayParts(int[] numbers, int index)
        {
            int[] exchangeNumbers = new int[numbers.Length];
            int exchangeNumberIndex = 0;

            for (int i = index + 1; i < numbers.Length; i++)
            {
                exchangeNumbers[exchangeNumberIndex] = numbers[i];
                exchangeNumberIndex++;
            }

            for (int i = 0; i <= index; i++) 
            {
                exchangeNumbers[exchangeNumberIndex] = numbers[i];
                exchangeNumberIndex++;

            }

            return exchangeNumbers;
        }

        static int MaxElementOfTypeIndex(int[] number, string oddOrEven)
        {
            int index = -1; 
            int maxValue = int.MinValue;

            for (int i = 0; i < number.Length; i++)
            {
                int currentNum = number[i];

                if (oddOrEven == "even")
                {
                    if (currentNum % 2 == 0 && currentNum >= maxValue)
                    {
                        maxValue = currentNum;
                        index = i;
                    }

                }
                else if (oddOrEven == "odd")
                {
                    if (currentNum % 2 != 0 && currentNum >= maxValue)
                    {
                        maxValue = currentNum;
                        index = i;
                    }
                }

            }
            return index;

        }

        static int MinElementOfTypeIndex(int[] number, string oddOrEven)
        {
            int index = -1;
            int minValue = int.MaxValue;

            for (int i = 0; i < number.Length; i++)
            {
                int currentNum = number[i];

                if (oddOrEven == "even")
                {
                    if (currentNum % 2 == 0 && currentNum <= minValue)
                    {
                        minValue = currentNum;
                        index = i;
                    }

                }
                else if (oddOrEven == "odd")
                {
                    if (currentNum % 2 != 0 && currentNum <= minValue)
                    {
                        minValue = currentNum;
                        index = i;
                    }
                }

            }
            return index;

        }

        static void PrintFirstElementOfType(int[] numbers, int count, string oddOrEven)
        {
            int[] firstElements = new int[count];
            int firstElementIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                if (oddOrEven == "even")
                {
                    if (currentNum % 2 == 0 && firstElementIndex < count)
                    {
                        firstElements[firstElementIndex] = currentNum;
                        firstElementIndex++;

                    }

                }
                else if (oddOrEven == "odd")
                {
                    if (currentNum % 2 != 0 && firstElementIndex < count)
                    {
                        firstElements[firstElementIndex] = currentNum;
                        firstElementIndex++;

                    }
                }
            }

            Console.WriteLine(ArrayToStringFormat(firstElements, firstElementIndex));

        }

        static void PrintLastElementOfType(int[] numbers, int count, string oddOrEven)
        {
            int[] lastElements = new int[count];
            int lastElemetsIndex = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currentNum = numbers[i];

                if (oddOrEven == "even")
                {
                    if (currentNum % 2 == 0 && lastElemetsIndex < count)
                    {
                        lastElements[lastElemetsIndex] = currentNum;
                        lastElemetsIndex++;

                    }

                }
                else if (oddOrEven == "odd")
                {
                    if (currentNum % 2 != 0 && lastElemetsIndex < count)
                    {
                        lastElements[lastElemetsIndex] = currentNum;
                        lastElemetsIndex++;

                    }
                }
            }

            int[] reverseArray = new int[lastElemetsIndex];
            int reverseArrayIndex = 0;
            for (int i = lastElemetsIndex - 1; i >= 0; i--)
            {
                reverseArray[reverseArrayIndex++] = lastElements[i];
            }

            Console.WriteLine(ArrayToStringFormat(reverseArray, reverseArrayIndex));

        }

        static string ArrayToStringFormat(int[] arr, int elementsCount)
        {
            string output = string.Empty;
            output += "[";

            for (int i = 0; i < elementsCount; i++)
            {

                if (i == elementsCount - 1)
                {
                    output += $"{arr[i]}"; 
                }
                else
                {
                    output += $"{arr[i]}, ";

                }

            }
            output += "]";
            return output;
        }
    }
}
