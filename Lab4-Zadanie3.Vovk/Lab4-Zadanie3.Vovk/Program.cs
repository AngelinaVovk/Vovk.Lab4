using System;

namespace ConsoleApp 
{
    class Program
    {

        static double Y(double x)
        {
            double n = -3 * x / 2;
            return n;
        }
        static double MyRecursionMulti(double k)
        {
            if (k == 1) return Y(k);

            return Y(k) * MyRecursionMulti(k - 1);
        }
        static void Main(string[] args)
        {
            int F = Convert.ToInt32(Console.ReadLine());
            double m = MyRecursionMulti(F);
            Console.WriteLine(m);
        }
    }
}





