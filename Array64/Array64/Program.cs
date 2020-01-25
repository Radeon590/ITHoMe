//Даны три целочисленных массива A, B и C размера NA, NB, NC
//соответственно, элементы которых упорядочены по убыванию.Объеди-
//нить эти массивы так, чтобы результирующий целочисленный массив D
//(размера NA + NB + NC) остался упорядоченным по убыванию.
using System;

namespace Array64
{
    class Program
    {
        static void Main(string[] args)
        {
            int NA = Convert.ToInt32(Console.ReadLine());
            int NB = Convert.ToInt32(Console.ReadLine());
            int NC = Convert.ToInt32(Console.ReadLine());
            int ND = NA + NB + NC;
            int[] A = new int[NA];
            int[] B = new int[NB];
            int[] C = new int[NC];
            int[] D = new int[ND];
            for (int i = 0; i < NA; i++) {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < NB; i++)
            {
                B[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < NC; i++)
            {
                C[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Copy(A, 0, D, 0, NA);
            Array.Copy(B, 0, D, NA - 1, NB);
            Array.Copy(C, 0, D, NA + NB - 1, NC);
            Array.Sort(D);
            Array.Reverse(D);
            for (int i = 0; i < ND; i++)
            {
                Console.WriteLine(D[i]);
            }

        }
    }
}
