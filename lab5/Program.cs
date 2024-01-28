using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Factorial(double nn, out double y)
            {
                y = 1;
                for (int i = 1; i <= nn; i++)
                {
                    y *= i;
                }
            }

            void Stepen(double A, double j, out double y)
            {
                y = 1;
                for (int i = 1; i <= j; i++)
                {
                    y *= A;
                }

            }
                Console.WriteLine("Введите значение х");
                double x = double.Parse(Console.ReadLine());
                double s = x;
                Console.WriteLine($"S= {s}\n");
                int k = 1;
                int z = (-1);
                while (k <= 13)
                {

                    k = k + 2;
                    Stepen(x, k, out double S1);
                    Factorial(k, out double P1);
                    s = s + (S1 / P1) * z;
                    Console.WriteLine($"S= {s}\n");

                }
            
        }
    }
}
