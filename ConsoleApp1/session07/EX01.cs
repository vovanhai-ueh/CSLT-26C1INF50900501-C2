using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session07
{
    class Sinhvien
    {

    }
    internal class EX01
    {
        public static void Mai11n(string[] args)
        {
            /* int[] a;
             a=new int[5];*/

            /*int[] b = new int[5];
            b[0] = 10;
            b[1] = 20;
            b[2] = 7;
            b[3] = 9;
            b[4] = 11;

            //int[]c = new int[5] {10,20,7,9,11 };
            int[]c = {10,20,7,9,11 };*/
            /*Console.Write("Hay nhap so phan tu mang:");
            int n = int.Parse(Console.ReadLine());*/

            int n = 100;
            int[] mang = new int[n];
            //nhap_mang_bang_com(mang);
            nhap_mang_ngau_nhien(mang);
            in_mang(mang);

            /*thay_giatri_chan_bang_0(mang);
            Console.WriteLine("\nmang sau khi thay phan tu chan");*/
            
            Console.WriteLine("\nCac so nguyen to co trong mang: ");
            int_cac_soNgto_trong_mang(mang);

        }

        static void nhap_mang_bang_com(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"mang[{i}] = ");
                a[i] = int.Parse(Console.ReadLine()) ;
            }
        }

        static void nhap_mang_ngau_nhien(int[] a)
        {
            Random rnd =new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(10, 500);
            }
        }
        static void int_cac_soNgto_trong_mang(int[] a)
        {
            foreach(int item in a)
            {
                if(IsPrime(item))
                    Console.Write($"{item}, ");
            }
        }

        private static bool IsPrime(int item)
        {
            if(item < 2)
                return false;
            for (int i = 2; i <= item / 2; i++)
                if (item % i == 0)
                    return false;
            return true;
        }

        static void thay_giatri_chan_bang_0(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    a[i] = 0;
            }
        }

        static void in_mang(int[] a)
        {
            foreach(int v in a)
                Console.Write($"{v}, ");
        }
    }
}
