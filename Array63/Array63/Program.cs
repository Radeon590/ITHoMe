//Даны два массива A и B размера 5, элементы которых упорядочены
//по возрастанию.Объединить эти массивы так, чтобы результирующий
//массив C(размера 10) остался упорядоченным по возрастанию.
using System;

namespace Array63
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            int[] B = new int[5];
            int[] C = new int[10];
            for (int i = 0; i < 5; i++) {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++) {
                B[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Copy(A, 0, C, 0, 5);
            Array.Copy(B, 0, C, 5, 5);
            Array.Sort(C);
            for (int c = 0; c < 10; c++) {
                Console.WriteLine(C[c]);
            }
        }
    }
}
