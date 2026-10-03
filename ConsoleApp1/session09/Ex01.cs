using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session09 {
    internal class Ex01 {
        public static void Mainx(string[] args) {
            Console.OutputEncoding= System.Text.Encoding.UTF8;

            /*string s1="hello"; //String s1 = new String("hello");
            Console.WriteLine(s1);

            string ss = s1.Substring(1,2);
            Console.WriteLine(ss);*/

            //mshs,ten.tuoi,toan,ly,hoa

            //string info = "1001,Than thi det,16,7,6,8";
            string info = "1002,Cong tang ton thi Thuy tien,16,7,6,8";

            /*int pos = info.Substring(5).IndexOf(",");
            string name = info.Substring(5,pos);
            Console.WriteLine(name);

            string[] information = info.Split(',');
            Console.WriteLine($"Mã học sinh: {information[0]}");
            Console.WriteLine($"Tên học sinh: {information[1]}");
            Console.WriteLine($"Tuổi: {information[2]}");
            Console.WriteLine($"Điểm Toán: {information[3]}");
            Console.WriteLine($"Điểm Lý: {information[4]}");
            Console.WriteLine($"Điểm Hóa: {information[5]}");*/

            string s2 = "Internally, the text is stored as a Sequential read-only collection of Char objects.";
            
            /*for (int i = 0; i < s2.Length; i++) {
                Console.WriteLine($"{s2[i]}");
            }*/
            string s3 = s2.Replace("sequential","tuan tu", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(s3);
        }
    }
}
