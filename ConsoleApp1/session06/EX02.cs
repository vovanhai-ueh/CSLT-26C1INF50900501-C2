using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session06
{
    internal class EX02
    {
        public static void Main4(string[] args)
        {
            /*for (int i = 0; i < 10; i++)
            {
                if (i == 5) continue;//bỏ qua lần lặp hiện tại
                Console.WriteLine(i);
            }*/

            //string s = "Đại học Kinh tế TPHCM";

            /*for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }*/

            /*foreach(var c in s)
            {
                Console.WriteLine(c);
            }*/

            //printStartTriangle();
            printMultiplicationTable();
        }

        public static void printStartTriangle()
        {
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void printMultiplicationTable()
        {
            for (int i = 2; i <= 15; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($" {i} * {j} = {i*j}");
                }
                Console.WriteLine();
            }
        }
    }
}
