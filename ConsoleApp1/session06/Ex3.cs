using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session06
{
    class Sinhvien
    {
        public string Mssv { get; set; }
        public string Hoten { get; set; }
    }
    internal class Ex3
    {
        static void DoitenSV(Sinhvien sv)
        {
            sv.Hoten = "Than Thi Det";
        }


        public static void Mai33n(string[] args)
        {
            Sinhvien s =new Sinhvien();
            //s.Mssv = "w3245734875";
            //s.Hoten = "Tran Van Coi";
            s.Mssv = args[0];
            s.Hoten = args[1];
            Console.WriteLine($"MSSV {s.Mssv}, ho ten: {s.Hoten}");

            DoitenSV(s);

            Console.WriteLine($"MSSV {s.Mssv}, ho ten: {s.Hoten}");
        }
    }
}
