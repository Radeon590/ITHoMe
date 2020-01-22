using System;

namespace Array16
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[N];
            for (int i = 0; i < N; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ok");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(nums[i]);
                Console.WriteLine(nums[N - 1 - i]);
            }
        }
    }
}
