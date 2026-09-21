using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session06
{
    public class Ex04
    {

        /*public static long sum(int a, int b=0)
        {
            return (long)(a + b);
        }
        public static long sum(int a, int b, int c)
        {
            return (long)(a + b+c);
        }
        public static long sum(int a, int b, int c, int d)
        {
            return (long)(a + b+c+d);
        }*/


        public static long sum(params int []p)
        {
            long s = 0;
            foreach (int a in p)
                s += a;
            return s;
        }
        public static void Maineee(string[] args)
        {
            long l = sum(1);

            long l1 = sum(1, 2);
            long l2 = sum(1, 2, 3);
            long l3 = sum(1, 2, 3, 4);
            long l5 = sum(1, 2, 3, 4,2354,46,4,3,3,43,67,22,2,435,6,7,7);
            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);
            Console.WriteLine(l5);
        }
    }
}
