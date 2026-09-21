using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session05
{
    internal class Ex01
    {
        /// <summary>
        /// Write a C# Sharp program that takes two numbers as input and 
        /// performs an operation (+,-,*,x,/) on them and displays the result 
        /// of that operation.
        /// </summary>
        static void Bai_1()
        {
            Console.Write("Nhap so a ="); int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b ="); int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");
        }
        /// <summary>
        /// Write a C# Sharp program to display certain values of the 
        /// function x = y2 + 2y + 1 (using integer numbers for y, 
        /// ranging from -5 to +5).
        /// </summary>
        static void Bai_2()
        {

        }

        public static void Main1(string[] args)
        {
            Bai_1();
            Bai_2();
        }
    }
}
