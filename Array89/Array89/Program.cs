﻿using System;

namespace Array89
{
    class Program
    {
        static void Main(string[] args)
        {
                int N = Convert.ToInt32(Console.ReadLine());
                int[] A = new int[N];
                for (int i = 0; i < N; i++)
                {
                    A[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Sort(A);
                Array.Reverse(A);
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(A[i]);
                }
            }
        }
    }
