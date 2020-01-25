//Дан целочисленный массив A размера N, являющийся перестановкой
//(определение перестановки дано в задании Array49). Найти количество
//инверсий в данной перестановке, то есть таких пар элементов AI и AJ , в
//которых большее число находится слева от меньшего: AI > AJ при I<J.
using System;

namespace Array50
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++) {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            //

            for (int a = 0; a < N; a++) {
                for (int b = 0; b < N; b++) {
                    if (A[a]) { 
                    
                    }
                }
            }
        }
    }
}
