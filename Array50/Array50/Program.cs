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
            //Формирование массива
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Подсчёт
            int counter = 0;
            for (int i = 0; i < N-1; i++) {
                if (A[i] > A[i + 1]) {
                    counter++;
                }
            }
            //Дополнительная проверка
            if (A[N - 1] > A[0])
                counter++;

            Console.WriteLine("Кол-во инверсий: " + counter);
        }
    }
}
