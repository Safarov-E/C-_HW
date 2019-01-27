using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "Nikolay";
            string password = "12345";
            int kol = 0;
            do
            {
                Console.Write("Веедите логин: ");
                string vodLogin = Console.ReadLine();

                Console.Write("Веедите пароль: ");
                string vodPassword = Console.ReadLine();

                if (login == vodLogin && password == vodPassword)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Добро пожаловать {login}");
                    
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Не вернно введен, логин или пароль, проверьте правильность  введенных данных, и повторите попытку");
                    Console.WriteLine();
                    ++kol;
                }
            } while (kol < 3);
            
        }
    }
}
