using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session06
{
    public class EXercises
    {

        public static void Main(string[] args)
        {
            //so_hoan_thien();
            //so_nguyen_to();
            in_N_snt_dautien();
        }

        static void so_hoan_thien()
        {
            Console.Write("Nhap so can kiem tra: ");
            int so = int.Parse(Console.ReadLine());

            int tong = 0;
            for (int i = 1; i <= so/2; i++)
            {
                if (so % i == 0)
                    tong += i;
            }

            if (tong == so)
            {
                Console.WriteLine($"So {so} la so hoan thien");
            }else
                Console.WriteLine($"So {so} KHONG la so hoan thien");
        }

        static void so_nguyen_to()
        {
            Console.Write("Nhap so can kiem tra: ");
            int so = int.Parse(Console.ReadLine());

            bool kt = true;//giả sử số cần ktra là số nguyên tố
            for(int i=2;i<=so/2;i++)
            {
                if (so % i == 0) //chỉ ra nó tồn tại ước số
                {
                    kt = false;//khẳng định nó không phải nguyên tố
                    break;
                }
            }
            if (kt)
                Console.WriteLine($"So {so} la so nguyen to");
            else
                Console.WriteLine($"So {so} KHONG la so nguyen to");
        }

        static void in_N_snt_dautien()
        {
            Console.Write("Ban muon in bao nhieu so nguyen to: ");
            int N = int.Parse(Console.ReadLine());

            int dem = 0;
            int so = 2;
            while (dem<=N)
            {

                bool kt = true;//giả sử số cần ktra là số nguyên tố
                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0) //chỉ ra nó tồn tại ước số
                    {
                        kt = false;//khẳng định nó không phải nguyên tố
                        break;
                    }
                }
                if (kt) { 
                    dem++;
                    Console.Write($"{so}, ");
                    if(dem%10==0)
                        Console.WriteLine();
                }
                so++;
            }
        }
    }
}
