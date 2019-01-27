using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        static int Min(int a, int b, int c)
        {
            int min = (a <= b) ? a : b;
            min = (c < min) ? c : min;
            return min;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Введите число \na = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine($"минимальное число из введеных { Min(a, b, c)}");
            Pause();
        }
    }
}
