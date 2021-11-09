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
            int q = F3(x,y);
            Console.WriteLine("Результат:" + q);

            char p = Convert.ToChar(Console.ReadLine());
            char k = Convert.ToChar(Console.ReadLine());
            int z = R(p, k);
            Console.WriteLine("Результат:" + z);

            double a = Convert.ToDouble(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());
            double w = D(a,r);
            Console.WriteLine("Результат:" + w);
        }
        static int F1(int x)
        {
            int a = 5 * x - 23 / 9;
            return a;
        }
        static int F2(int y)
        {
            int b = (int)(-2 * Math.Pow(y, 2));
            return b;
        }
        static int F3(int x, int y)
        {
            int g = F1(x);
            int s = F2(y);
            int p = Math.Max(g, s);
            return p;
        }
        static double D1(double a)
        {
            double b1 = 5 * a - 23 / 9;
            return b1;
        }
        static double D2(double r)
        {
            double b2 = (-2 * Math.Pow(r, 2));
            return b2;
        }
        static double D(double a, double r)
        {
            double b = D1(a);
            double c = D2(r);
            double e = Math.Max(b, c);
            return e;
        }
        static int R1(char p)
        {
            int k = 5 * p - 23 / 9;
            return k;
        }
        static int R2(char k)
        {
            int j = (int)(-2 * Math.Pow(k, 2));
            return j;
        }
        static int R(char p, char k)
        {
            int c = R1(p);
            int d = R2(k);
            int o = Math.Max(c, d);
            return o;
        }
    }
}






























