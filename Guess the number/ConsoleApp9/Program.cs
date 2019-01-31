using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            int maxCount = (int)Math.Log(max - min + 1, 2) + 1;
            int count = 0;
            Random md = new Random();
            int guessNumber = md.Next(min, max);
            Console.WriteLine($"Компьютер загадал число от {min} до {max}. Попробуйте угадать его за {maxCount} попыток");
            int n;
            do
            {
                count++;
                Console.WriteLine($"{count} попытка. Введите число:");
                n = int.Parse(Console.ReadLine());
                if (n > guessNumber) Console.WriteLine("Перелет!");
                if (n < guessNumber) Console.WriteLine("Недолет!");
            }
            while(count < maxCount && n!=guessNumber);
            if (n == guessNumber) Console.WriteLine($"Поздравляю! Вы угадали число за {count} попыток");
            else Console.WriteLine("Неудача. Попробуйте еще раз");
        }
    }
}
