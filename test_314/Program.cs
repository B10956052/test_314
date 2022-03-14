using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_314
{
    class Program
    {
        static void Main(string[] args)
        {
            /* if判斷練習
            Console.Write("請輸入一個數:");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                if (x >= 2 && x <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (x >= 6 && x <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else if (x > 20)
                {
                    Console.WriteLine("Not Weird");
                }
            }
            else
            {
                Console.WriteLine("Weird");
            }
            */

            /* for迴圈練習1
            for(int i = 1 ; i <= 5 ; i++)
            {
                for(int j = 1 ; j <= i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            */

            /* for迴圈練習2
            Console.Write("請輸入一個數:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入你要乘的行數:");
            int y = Convert.ToInt32(Console.ReadLine());
            for(int i = 1 ; i <= y ; i++)
            {
                Console.WriteLine(x + "*" + i + "=" + x * i);
            }
            */

            /* for迴圈練習3
            for(int i = 1 ; i <= 9 ; i++)
            {
                for(int j = 1 ; j <= 9 ; j++)
                {
                    Console.Write(i + "*" + j + "=" + i * j+"  ");
                }
                Console.WriteLine("");
            }
            */

            /* 陣列練習
            int[,] score = { { 80, 75, 60 }, { 65, 67, 62 }, { 100, 93, 91 }, { 98, 25, 50 }, { 83, 82, 87 } };
            string[] name = { "Jack", "Mary", "Tom", "Grace", "Alice" };

            Console.Write("輸入座號(1-5):");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number >= 1 && number <= 5)
            {
                Console.WriteLine("1.姓名:" + name[number - 1]);
                Console.WriteLine("2.電腦概論:" + score[number - 1, 0]);
                Console.WriteLine("3.程式設計:" + score[number - 1, 1]);
                Console.WriteLine("4.動畫設計:" + score[number - 1, 2]);
            }
            else
            {
                Console.WriteLine("...座號超出範圍...");
            }
            */
        }
    }
}
