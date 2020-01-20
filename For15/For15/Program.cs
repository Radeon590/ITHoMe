//Дано вещественное число A и целое число N (> 0). Найти A в степе-
//ни N :
//AN = A·A· . . . ·A
//(числа A перемножаются N раз).

using System;

namespace For15
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            int a = A;
            for (int i = 2; i <= N; i++) {
                a = a * A;
            }
            Console.WriteLine(a);
        }
    }
}
