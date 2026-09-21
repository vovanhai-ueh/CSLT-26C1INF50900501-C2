using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_26C1INF50900501_C2.session07
{
    internal class exercise
    {

        public static void Main(string[] args)
        {
            int n = 50;
            int[] mang = new int[n];
            nhap_mang_ngau_nhien(mang);
            in_mang(mang);
            Console.WriteLine();
            float avg = calcAvg(mang);
            Console.WriteLine($"Trung binh gia tri cua mang la {avg}");
        }
        static void nhap_mang_ngau_nhien(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(10, 500);
            }
        }

        static void in_mang(int[] a)
        {
            foreach (int v in a)
                Console.Write($"{v}, ");
        }
        
        //to calculate the average value of array elements.
        static float calcAvg(int[] a)
        {
            int sum = 0;
            foreach(int v in a)
                sum+= v;
            return (float)sum/a.Length;
        }

        //to test if an array contains a specific value.
        static bool searchByValue(int[] a, int x)
        {
            foreach (int v in a)
                if (v == x)
                    return true;
            return false;
        }
        //to find the index of an array element.
        static int searchIndex(int[]a, int x)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }
        //to remove a specific element from an array.


        //to find the maximum and minimum value of an array.

        //to reverse an array of integer values.

        //to find duplicate values in an array of values.

        //to remove duplicate elements from an array.

    }
}
