using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_C2.session05
{
    public class Ex02
    {
        static void gameEngine()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1. máy tính nghĩ ra 1 số ngẫu nhiên từ 1-10
            Random rnd =new Random();
            int comNum = rnd.Next(0,10) + 1;
            //Console.WriteLine(comNum);

            //2. Người dùng đoán (nhập dữ liệu)
            Console.Write("Bạn đoán số mấy <1..10>?: ");
            int userNam = int.Parse(Console.ReadLine());
            //3. Báo kết quả
            if (userNam == comNum)//đoán đúng
            {
                Console.WriteLine("Bravo, You are genius!");
            }
            else //đoán sai
            {
                Console.WriteLine($"Bạn sai rồi. Máy nghĩ ra số {comNum}");
            }

            Console.WriteLine("Bye");
        }

        public static void Main1(string[] args)
        {
            Console.WriteLine("welcome to guessing number game\n");
            gameEngine();
        }
    }
}
