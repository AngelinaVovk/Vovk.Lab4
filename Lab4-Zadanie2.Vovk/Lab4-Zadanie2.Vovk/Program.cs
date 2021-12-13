using System;
//пространство имен
namespace ConsoleApp
{
    //класс программы
    class Program
    {
            static double Y(double x)
            {
                double n = (x + 1) / 5.0;
                return n;
            }

            static double MyFunctionRecursionSum(double k)
            {
                if (k == 1) return Y(k);

                return Y(k) + MyFunctionRecursionSum(k - 1);
               
            }
            static void Main(string[] args)
            {
                int F = Convert.ToInt32(Console.ReadLine());
                double m = MyFunctionRecursionSum(F);
                Console.WriteLine(m);
            }
        
    }
}


        
          
