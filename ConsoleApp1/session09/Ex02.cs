using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session09 {
    internal class Ex02 {
        public static void Main11(string[] args) {
            /*int[][] arr = new int[3][];
            arr[0] = new int[1] { 1 };
            arr[1] = new int[3] { 2, 3, 4 };
            arr[2] = new int[2] { 5, 6 };

            PrintJaggedArray2(arr);*/

            int[][] arr = CreateRandomJaggedArr(5, 1, 10, 1, 100);
            PrintJaggedArray(arr);

            Console.WriteLine("\nCác phần tử chẵn trong mảng:");
            PrintEvenItems(arr);
        }

        /// <summary>
        /// Tạo mảng răng cưa (jagged array) ngẫu nhiên với số dòng, số cột và giá trị trong khoảng cho trước
        /// </summary>
        /// <param name="rows">Số dòng của mảng</param>
        /// <param name="minCols">Số cột tối thiểu của mỗi dòng</param>
        /// <param name="maxCols">Số cột tối đa của mỗi dòng</param>
        /// <param name="minVal">Giá trị tối thiểu của các phần tử</param>
        /// <param name="maxVal">Giá trị tối đa của các phần tử</param>
        /// <returns></returns>
        public static int[][] CreateRandomJaggedArr(int rows, int minCols, int maxCols, int minVal, int maxVal) {
            Random rand = new Random();
            int[][] arr = new int[rows][];
            for (int i = 0; i < rows; i++) {
                int cols = rand.Next(minCols, maxCols + 1);
                arr[i] = new int[cols];
                for (int j = 0; j < cols; j++) {
                    arr[i][j] = rand.Next(minVal, maxVal + 1);
                }
            }
            return arr;
        }

        public static void PrintJaggedArray(int[][] arr) {
            for (int i = 0; i < arr.Length; i++) {//duyệt qua số dòng (arr.Length là số dòng)
                for (int j = 0; j < arr[i].Length; j++) {//duyệt qua số cột của dòng i (arr[i].Length là số cột của dòng i)
                    Console.Write($"{arr[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static void PrintJaggedArray2(int[][] arr) {
            foreach (int[] row in arr) {//duyệt qua từng dòng của mảng
                foreach (int item in row) { //duyệt qua từng phần tử của dòng
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintEvenItems(int[][] arr) {
            foreach (int[] row in arr) {//duyệt qua từng dòng của mảng
                foreach (int item in row) { //duyệt qua từng phần tử của dòng
                    if (item % 2 == 0) {
                        Console.Write($"{item} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}