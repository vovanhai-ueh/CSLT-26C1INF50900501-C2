using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session07
{
    internal class Sinhvien
    {
        public void phatbieu(string topic)
        {
            Console.WriteLine($"Sinhvien phat bieu {topic}");
        }

        public static void noichuyen()
        {
            Console.WriteLine("Sinhvien noi chuyen linh tinh");
            return;
        }

        static float calcGPA(float a, float b, float c)
        {
            float rs = (a + b + c) / 3f;
            return rs;
        }


        public static void Main434(string[] args)
        {

            /* Sinhvien s = new Sinhvien();
             s.phatbieu("reactive prtogramming");

             noichuyen();*/
            /*int x = 0, y = 10;
            int c = add(x, y);  //x,y: actual params
            Console.WriteLine(c);*/


            int k = 100;
            float x = 20;
            double kq = add(b:k, a:x);
            //double kq2 = add(x, k);
            add(3, 1);
            add(3f, 1);

        }



        static int add(int a, int b) //a,b: formal params
        {
            if (a == 0)
                return b;
            //.....
            return a + b;
        }
        static int add(float a, int b)
        {
            return (int)a + b;
        }

        /* static double  add(int a, float b)
         {
             return a + b;
         }*/



    }
}
