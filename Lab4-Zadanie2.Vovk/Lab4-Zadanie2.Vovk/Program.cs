﻿using System;
//пространство имен
namespace ConsoleApp
{
    //класс программы
    class Program
    {
            static double Y(double x)
            {
                Console.WriteLine("Результат: ");
                double n = (x + 1) / 5;
                Console.WriteLine(n);
                return n;
            }

            static double MyFunctionRecursionSum(double k)
            {
                if (k == 0)
                {
                    return Y(k);
                }
                else
                {
                    return Y(k) + MyFunctionRecursionSum(k-1);
                }
            }
            static void Main(string[] args)
            {
                int F = Convert.ToInt32(Console.ReadLine());
                double m = MyFunctionRecursionSum(F);
                Console.WriteLine(F);
            }
        
    }
}


        
          
