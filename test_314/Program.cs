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
        }
    }
}
