using System;

namespace ConsoleApp 
{
    class Program
    {

        static double Y(double n)
        {
            double x = -3 * n / 2;
            return x;
        }
        static double MyRecursionMulti(double k)
        {
            if (k == 0)
            {
                return 1;
            }
            else
            {
                return Y(k) * MyRecursionMulti(1);
            }
        }
        static void Main(string[] args)
        {
            int F = Convert.ToInt32(Console.ReadLine());
            double m = MyRecursionMulti(F);
            Console.WriteLine(F);
        }
    }
}





