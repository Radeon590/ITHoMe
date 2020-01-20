//Даны три числа.Найти сумму двух наибольших из них.
using System;

namespace If15
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0, B = 0, C = 0;
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (a > b || a > c) {
                A = a;
            }
            if (b > a || b > c) {
                B = b;
            }
            if (c > a || c > b) {
                C = c;
            }
            Console.WriteLine(A + B + C);
        }
    }
}
