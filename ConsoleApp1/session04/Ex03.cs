using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session05
{
    internal class Ex03
    {
        /// <summary>
        /// Nhập vào 1 số.
        /// In ra chữ số tương ứng.
        /// Ví dụ: nhập số 5 sẽ in ra chữ "năm"
        /// </summary>
        static void Number2String()
        {
            Console.Write("Nhập 1 số <0..9>?: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0 || number > 10)
            {
                Console.WriteLine("NGoài giới hạn hiển thị");
            }
            else
            {
                if (number == 0) Console.WriteLine("không");
                else if (number == 1) Console.WriteLine("một");
                else if (number == 2) Console.WriteLine("hai");
                else if (number == 3) Console.WriteLine("ba");
                else if (number == 4) Console.WriteLine("bốn");
                else if (number == 5) Console.WriteLine("năm");
                else if (number == 6) Console.WriteLine("sáu");
                else if (number == 7) Console.WriteLine("bảy");
                else if (number == 8) Console.WriteLine("tám");
                else if (number == 9) Console.WriteLine("chín");
            }
        }

        static void Number2StringV2()
        {
            Console.Write("Nhập 1 số <0..9>?: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 0: Console.WriteLine("không"); break;
                case 1: Console.WriteLine("một"); break;
                case 2: Console.WriteLine("hai"); break;
                case 3: Console.WriteLine("ba"); break;
                case 4: Console.WriteLine("bốn"); break;
                case 5: Console.WriteLine("năm"); break;
                case 6: Console.WriteLine("sáu"); break;
                case 7: Console.WriteLine("bảy"); break;
                case 8: Console.WriteLine("tám"); break;
                case 9: Console.WriteLine("chín"); break;
                default:
                    Console.WriteLine("Số ngoài giới hạn hiển thị"); break;
            }
        }
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Number2String();
            Number2StringV2();
        }
    }
}
