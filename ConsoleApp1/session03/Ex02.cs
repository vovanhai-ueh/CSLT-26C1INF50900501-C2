using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session03
{
    internal class Ex02
    {

        static void Bai_1()
        {
            Console.Write("Nhập chỉ số điện cũ (kWh):");
            float csd_cu = float.Parse(Console.ReadLine());
            float csd_moi;
            do
            {
                Console.Write("Nhập chỉ số điện mới (kWh):");
                csd_moi = float.Parse(Console.ReadLine());
                if (csd_moi >= csd_cu)
                    break;
                else
                    Console.WriteLine("\t*** CHỉ số mới phải lớn hơn hoặc bằng chỉ số cũ.");
            } while (true);

            //Tính lượng điện tiêu thụ trong tháng = Chỉ số mới - Chỉ số cũ.
            float tieuThu = csd_moi - csd_cu;
            //Giả sử đon giá cố định 1 chữ là 3059 đồng /1 kWh
            float dongia = 3059f;

            decimal tienDien = (decimal)(tieuThu * dongia);//cast

            //thuế VAT
            decimal vat = (decimal)(tieuThu * 0.08f);

            //in ra hóa đơn
            Console.WriteLine($"\nSố điện tiêu thụ: {tieuThu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien:C}");
            Console.WriteLine($"Thuế VAT (8%): {vat:C}");
            Console.WriteLine($"Tổng thanh toán: {tienDien + vat:C}");
        }

        static void Bai_2()
        {

        }
        static void Bai_3()
        {

        }
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Bai_1();
            Bai_2();
            Bai_3();

            Console.Write("\nNhấn phím bất kỳ để kết thúc");
            Console.ReadKey();

        }
    }
}
