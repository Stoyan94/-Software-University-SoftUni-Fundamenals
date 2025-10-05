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
    
    
                // колко можем да махнем вляво (ако бомбата е близо до началото)
                int indicesToRemoveLeft = Math.Min(bombPower, bombIndex);
    
    
                // колко можем да махнем вдясно (ако бомбата е близо до края)
                int indicesToRemoveRight = Math.Min(bombPower, numbers.Count - bombIndex - 1);
    
    
                // изчисляваме от кой индекс започва махането
                int startIndex = bombIndex - indicesToRemoveLeft;
    
    
                // изчисляваме колко елемента общо да махнем
                int count = indicesToRemoveLeft + indicesToRemoveRight + 1; // +1 за самата бомба
    
    
                // махаме диапазона от списъка
                numbers.RemoveRange(startIndex, count);
            }
    
            // Накрая печатаме сумата на останалите елементи
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
