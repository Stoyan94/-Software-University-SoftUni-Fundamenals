using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Bomb_Numbers
{
       internal class Program
    {
        static void Main(string[] args)
        {
            // Четем списъка от числа от конзолата
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
    
            // Четем бомбата и силата ѝ
            int[] bombData = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
    
            int bombNumber = bombData[0]; // самият бомбен номер
            int bombPower = bombData[1];  // силата (колко числа вляво и вдясно се махат)
    
            // Докато в списъка има бомба
            while (numbers.Contains(bombNumber))
            {
                // намираме индекса на първата бомба
                int bombIndex = numbers.IndexOf(bombNumber);
    
    
                               // Изчисляваме колко числа можем да махнем вляво от бомбата.
                // Ако бомбата е близо до началото на списъка, не можем да махнем повече от наличните елементи.
                // Math.Min гарантира, че няма да излезем извън границите на списъка.
                int indicesToRemoveLeft = Math.Min(bombPower, bombIndex);

                // Изчисляваме колко числа можем да махнем вдясно от бомбата.
                // Ако бомбата е близо до края, не можем да махнем повече от наличните елементи.
                // numbers.Count - bombIndex - 1 е броят елементи вдясно от бомбата.
                int indicesToRemoveRight = Math.Min(bombPower, numbers.Count - bombIndex - 1);

                // Изчисляваме от кой индекс започва премахването.
                // Изваждаме indicesToRemoveLeft, за да започнем от правилния елемент вляво от бомбата.
                int startIndex = bombIndex - indicesToRemoveLeft;

                // Изчисляваме общия брой елементи, които ще махнем:
                // indicesToRemoveLeft (вляво) + indicesToRemoveRight (вдясно) + 1 (самата бомба).
                int count = indicesToRemoveLeft + indicesToRemoveRight + 1;

                // Премахваме диапазон от списъка, започвайки от startIndex, с дължина count.
                // RemoveRange премахва всички елементи от startIndex до (startIndex + count - 1).
                numbers.RemoveRange(startIndex, count);

            }
    
            // Накрая печатаме сумата на останалите елементи
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
