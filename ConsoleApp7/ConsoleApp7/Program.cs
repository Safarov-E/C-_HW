using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите рост, пример ввода 174 см - 1,74");
            double Rost;
            
            
            Double Res = 0;
            while (!(double.TryParse(Console.ReadLine(), out Rost)))
            {
                Console.WriteLine("Ведите число");
            }
            Console.WriteLine("Ведите вес");
            int Ves;
            while (!(int.TryParse(Console.ReadLine(), out Ves)))
            {
                Console.WriteLine("Ведите число");
            }

            Res = Ves /  (Rost * Rost);
            Res = (int)Res;
            if (Res < 16)
            {
                Console.WriteLine($"Индекс массы тела {Res}");
                Console.WriteLine("Значительный дефицит масы тела");
            }
            if (Res >= 16 && Res <= 18)
            {
                Console.WriteLine($"Индекс массы тела {Res}");
                Console.WriteLine("Недостаток массы тела");
            }
            if (Res >= 18 && Res <= 25)
            {
                Console.WriteLine($"Индекс массы тела {Res}");
                Console.WriteLine("Норма веса");
            }
            if (Res >= 25 && Res <= 30)
            {
                Console.WriteLine($"Индекс массы тела {Res}");
                Console.WriteLine("Излишек массы тела (лишний вес)");
            }
            if (Res >= 30 && Res <= 35)
            {
                Console.WriteLine($"Индекс массы тела {Res}");
                Console.WriteLine("Начальная степень ожирения");
            }
            if (Res >= 35 && Res <= 40)
            {
                Console.WriteLine($"Индекс массы тела {Res}");
                Console.WriteLine("Средняя степень ожирение");
            }
            if (Res > 40)
            {
                Console.WriteLine($"Индекс массы тела {Res}");
                Console.WriteLine("Ожирение высокой степени");
            }
            //Console.WriteLine($"Ведите вес {Res}");
            //Console.ReadKey();
        }
    }
}
