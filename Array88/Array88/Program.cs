//Дан массив размера N, все элементы которого, кроме последнего,
//упорядочены по возрастанию.Сделать массив упорядоченным, переме-
//стив последний элемент на новую позицию.
using System;

namespace Array88
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++) { 
            A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(A);
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}
