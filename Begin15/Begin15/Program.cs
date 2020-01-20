//Дана площадь S круга. Найти его диаметр D и длину L окружности,
//ограничивающей этот круг, учитывая, что L = 2·pi·R,
//значения pi использовать 3.14.
using System;

namespace Begin15
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = Convert.ToDouble(Console.ReadLine()) / 3.14;
            double R = Math.Sqrt(S);
            Console.WriteLine(2 * 3.14 * R + "\t" + 2* R);

        }
    }
}
