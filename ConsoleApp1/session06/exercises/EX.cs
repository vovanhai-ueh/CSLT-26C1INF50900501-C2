using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session06.exercises
{
    internal class EX
    {
        /// <summary>
        /// Hàm kiểm tra 1 số có phải là số nguyên tố
        /// </summary>
        /// <param name="number">là số cần kiểm tra</param>
        /// <returns>true nếu là số cần ktra là số nguyên tố</returns>
        static bool IsPrime(int number)
        {   if (number < 2) return false;
            for (int i = 2; i <= number/2; i++) { 
                if (number % i == 0) //tồn tại 1 ước số khác 1 và chính nó
                    return false;
            }
            return true;
        }

        /// <summary>
        /// In ra các số nguyên tố nhỏ hơn N
        /// </summary>
        /// <param name="n">là giới hạn mà các số ngto phải nhỏ hơn</param>
        static void PrintPrimeNumbersUnderN(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if(IsPrime(i))
                    Console.Write($"{i}, ");
            }
        }

        static void PrintFirstNPrimeNumbers(int n)
        {
            int dem = 0;
            int so = 2;
            while (dem < n)
            {
                if (IsPrime(so))
                {
                    Console.Write($"{so}, ");
                    dem++;
                }
                so++;
            }
        }


        public static void Main222(string[] args)
        {
            /*Console.Write("Nhap so can kiem tra: ");
            int so =int.Parse(Console.ReadLine());
            if( IsPrime(so))
                Console.WriteLine($"{so} la so nguyen to");
            else
                Console.WriteLine($"{so} KHONG la so nguyen to");*/

            Console.Write("Nhap so n= ");
            int so = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Cac so nguyen to nho hon {so}");
            PrintPrimeNumbersUnderN(so);
            Console.WriteLine($"\n{so} so nguyen to dau tien");
            PrintFirstNPrimeNumbers(so);
        }
    }
}
