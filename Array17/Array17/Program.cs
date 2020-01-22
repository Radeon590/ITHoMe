//Дан массив A размера N.Вывести его элементы в следующем порядке:
//A0, A1, AN , AN−1, A2, A3, AN−2, AN−3, . . . .
using System;

namespace Array17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[N];
            for(int i = 0; i < N; i++){
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ok");
            for (int i = 0; i < N; i++) {
                Console.WriteLine(nums[i]);
                b++;
                if (b == 2) {
                    Console.WriteLine(nums[N - 1 - a]);
                    a++;
                    Console.WriteLine(nums[N - 1 - a]);
                    a++;
                    b = 0;
                }
            }
            
        }
    }
}
