using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            int a;
            while (true)
            {
                while (!(int.TryParse(Console.ReadLine(), out a)))
                {
                    Console.WriteLine("Веедите число");
                }
                if (a != 0)
                {
                    if (a % 2 == 0)
                    {

                    }
                    else
                    {
                        b += a;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"сумму всех нечетных положительных чисел {b}");
        }
    }
}
