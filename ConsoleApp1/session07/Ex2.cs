using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session07
{
    internal class Ex2
    {
        /// <summary>
        /// hoán đổi giá trị a,b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b= temp;
            Console.WriteLine($"Trong khi swap x ={a}, y = {b}");
        }

        static void foo(out int x)
        {
            x = 0;
            x = x + 5;
        }
        static int cong(int a, int b)
        {
            return a + b;
        }

        public static void Maisdsdn(string[] args)
        {
            /* int x = 3, y = 5;
             Console.WriteLine($"Truoc khi swap x ={x}, y = {y}");
             swap(ref x, ref y);
             Console.WriteLine($"Sau khi swap x ={x}, y = {y}");*/
            int a;
            foo(out a);
            Console.WriteLine(a);
            int k = 10, l = 3;
            int kq = cong(k, l);
        }
    }
}
