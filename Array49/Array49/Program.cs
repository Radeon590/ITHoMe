//Дан целочисленный массив размера N.Если он является переста-
//новкой, то есть содержит все числа от 1 до N, то вывести 0; в противном
//случае вывести номер первого недопустимого элемента.
using System;

namespace Array49
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            bool masP = false;
            //Массив
            int N = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[N];
            for (int i = 0; i < N; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ok");
            //

            //
            for (int i = 0; i < N; i++) {
                if ((i + 1) == a)
                {
                    masP = true;
                    a++;
                }
                else {
                    masP = false;
                    Console.WriteLine(a);
                    break;
                }
            }
            if (masP == true) {
                Console.WriteLine("0");
            }

        }
    }
}
