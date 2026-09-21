using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session07
{
    internal class ex_03
    {
        static void khoitaomang_kb(int[,]a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for(int j=0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void khoitaomang_random(int[,] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(1, 10);
                }
            }
        }

        static void in_mang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($" {a[i,j]}\t");
                }
                Console.WriteLine();
            }
        }

        static int tinhtongsocahntrendong(int[,] a, int dong)
        {
            int sum = 0;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[dong,j] %2 ==0)
                    sum += a[dong, j];
            }
            return sum;
        }

        static int tongcot(int[,] a, int cot)
        {
            int sum = 0;
            for(int i = 0; i < a.GetLength(0); i++)
            {
                sum += a[i, cot];
            }
            return sum;
        }

        static int maxValue(int[,] a)
        {
            int max = a[0,0];
            foreach(int item in a)
            {
                if(item > max)
                    max = item;
            }
            return max;
        }

        static int max_dong(int[,]a, int row)
        {
            int max = a[row, 0];
            for(int j = 1;j < a.GetLength(1); j++)
            {
                if (a[row,j]>max)
                    max = a[row,j];
            }
            return max;
        }

        public static void Main(string[] args)
        {
            int n = 5, m = 6;

            /*int[,] mang2c;
            mang2c = new int[n, m];

            //int[,] mang2c = new int[n, m];

            *//*int[,] m2 =new int[2, 2]
            {
                {1,2 },
                {3,4 }
            };*//*
            int[,] m2 = {
                {1,2 },
                {3,4 }
            };*/

            int[,] mang = new int[n, m];
            //khoitaomang_kb(mang);
            khoitaomang_random(mang);
            Console.WriteLine("\nmang ket qua");
            in_mang(mang);

            int dong = 3;
            int s = tinhtongsocahntrendong(mang, dong);
            Console.WriteLine($"tong gia tri tren dong so {dong} la {s}");
            int w = tongcot(mang, 2);
            Console.WriteLine($"TOng gia tri o cot so 2 = {w}");
        }
    }
}
