using System;
//пространство имен
namespace ConsoleApp
{
    //класс программы
    class Program
    {
        // метод Main - точка начала выполнения команды
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х и у");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            double a = 5 * x - 23 / 9.0;
            double b = -2 * y * y;
            Console.WriteLine($"a:{a},b:{b}");
            Console.WriteLine($"Большее:{Max(a, b) }");
            static double Max(double a, double b)
            {
                return a > b ? a : b;
            }
            Console.WriteLine("Введите p и k");
            char p = Convert.ToChar(Console.ReadLine());
            char k = Convert.ToChar(Console.ReadLine());
            double m = 5 * p - 23 / 9.0;
            double n = -2 * k * k;
            Console.WriteLine($"m:{m},n:{n}");
            Console.WriteLine($"Большее:{Maxi(m, n) }");
            static double Maxi(double m, double n)
            {
                return m > n ? m : n;
            }
        }
    }
}












